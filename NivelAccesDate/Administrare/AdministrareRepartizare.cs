using LibrarieModele;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Data;
using System.Configuration;

namespace NivelAccesDate
{
    public class AdministrareRepartizare : IStocareRepartizari
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        private readonly string _NumeTabelLiceu = ConfigurationManager.AppSettings.Get("K_NumeTabelLiceu");
        private readonly string _NumeTabelMaterii = ConfigurationManager.AppSettings.Get("K_NumeTabelMaterii");
        private readonly string _NumeTabelOras = ConfigurationManager.AppSettings.Get("K_NumeTabelOras");
        private readonly string _NumeTabelProfesor = ConfigurationManager.AppSettings.Get("K_NumeTabelProfesor");
        private readonly string _NumeTabelRepartizare = ConfigurationManager.AppSettings.Get("K_NumeTabelRepartizare");


        public bool AddRepartizare(Repartizare r)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_NumeTabelRepartizare} VALUES (:idProfesor, :idLiceu)", CommandType.Text,
                new OracleParameter(":idProfesor", OracleDbType.Int32, r.idProfesor, ParameterDirection.Input),
                new OracleParameter(":idLiceu", OracleDbType.Int32, r.idLiceu, ParameterDirection.Input));
        }
        public bool UpdateRepartizare(Repartizare r, int idLiceuVechi)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_NumeTabelRepartizare} set idLiceu = :idLiceu where idProfesor = :idProfesor AND idLiceu = :idLiceuVechi", CommandType.Text,
                new OracleParameter(":idLiceu", OracleDbType.Int32, r.idLiceu, ParameterDirection.Input),
                new OracleParameter(":idProfesor", OracleDbType.Int32, r.idProfesor, ParameterDirection.Input),
                new OracleParameter(":idLiceuVechi", OracleDbType.Int32, idLiceuVechi, ParameterDirection.Input));
        }
        public bool DeleteRepartizarePentruLiceu(int idLiceu)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelRepartizare} WHERE idLiceu = :idLiceu", CommandType.Text,
                    new OracleParameter(":idLiceu", OracleDbType.Int32, idLiceu, ParameterDirection.Input));
        }
        public bool DeleteRepartizarePentruProfesor(int idProfesor)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelRepartizare} WHERE idProfesor = :idProfesor", CommandType.Text,
                    new OracleParameter(":idProfesor", OracleDbType.Int32, idProfesor, ParameterDirection.Input));
        }
        public bool DeleteRepartizare(Repartizare r)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelRepartizare} WHERE idLiceu = :idLiceu AND idProfesor = :idProfesor", CommandType.Text,
                    new OracleParameter(":idLiceu", OracleDbType.Int32, r.idLiceu, ParameterDirection.Input),
                    new OracleParameter(":idProfesor", OracleDbType.Int32, r.idProfesor, ParameterDirection.Input)
                    );
        }


        public Repartizare GetRepartizare(int idP, int idL)
        {
            Repartizare result = null;
            var dsRepartizari = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelRepartizare} where idProfesor = :idProfesor AND idLiceu = :idLiceu", CommandType.Text,
                new OracleParameter(":idProfesor", OracleDbType.Int32, idP, ParameterDirection.Input),
                new OracleParameter(":idLiceu", OracleDbType.Int32, idL, ParameterDirection.Input));

            if (dsRepartizari.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsRepartizari.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Repartizare(linieDB);
            }
            return result;
        }
        public List<Repartizare> GetRepartizari()
        {
            var result = new List<Repartizare>();
            var dsRepartizari = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelRepartizare}", CommandType.Text);

            foreach (DataRow linieDB in dsRepartizari.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Repartizare(linieDB));
            }
            return result;
        }


        #region Pentru Afisari
        public DataSet GetDetaliiRepartizari()
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT P.idProfesor, P.nume AS numeProfesor, P.prenume, L.idLiceu, L.nume AS numeLiceu, M.idMaterie, M.nume AS numeMaterie, O.idOras, O.nume AS numeOras " +
                                                        $"FROM {_NumeTabelProfesor} P, {_NumeTabelMaterii} M, {_NumeTabelRepartizare} R, {_NumeTabelLiceu} L, {_NumeTabelOras} O " + 
                                                        $"WHERE P.idMaterie = M.idMaterie AND L.idOras = O.idOras AND P.idProfesor = R.idProfesor AND R.idLiceu = L.idLiceu", CommandType.Text);
            return dsPrograme;
        }

        public DataSet GetDetaliiCautaRepartizariLiceu(int l)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT P.idProfesor, P.nume AS numeProfesor, P.prenume, L.idLiceu, L.nume AS numeLiceu FROM {_NumeTabelProfesor} P, {_NumeTabelLiceu} L, {_NumeTabelRepartizare} R " +
                                                          $"WHERE L.idLiceu = R.idLiceu AND P.idProfesor = R.idProfesor AND L.idLiceu = :idLiceu", CommandType.Text,
                                                          new OracleParameter(":idLiceu", OracleDbType.Int32, l, ParameterDirection.Input));
            return dsPrograme;
        }
        
        public DataSet GetDetaliiCautaRepartizariNumeSauPrenume(string tip, string str)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT P.idProfesor, P.nume AS numeProfesor, P.prenume, L.idLiceu, L.nume AS numeLiceu FROM {_NumeTabelProfesor} P, {_NumeTabelLiceu} L, {_NumeTabelRepartizare} R " +
                                                          $"WHERE L.idLiceu = R.idLiceu AND P.idProfesor = R.idProfesor AND Upper(P.{tip}) like '%{str.ToUpper()}%'", CommandType.Text);
            return dsPrograme;
        }

        public DataSet GetDetaliiCautaRepartizareNumeSiPrenume(string nume, string prenume)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT P.idProfesor, P.nume AS numeProfesor, P.prenume, L.idLiceu, L.nume AS numeLiceu FROM {_NumeTabelProfesor} P, {_NumeTabelLiceu} L, {_NumeTabelRepartizare} R " +
                                                          $"WHERE L.idLiceu = R.idLiceu AND P.idProfesor = R.idProfesor AND Upper(P.nume) like '%{nume.ToUpper()}%' AND Upper(P.prenume) like '%{prenume.ToUpper()}%' ", CommandType.Text);

            return dsPrograme;
        }
        
        public DataSet GetDetaliiCautaRepartizare(int l, string nume, string prenume)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT P.idProfesor, P.nume AS numeProfesor, P.prenume, L.idLiceu, L.nume AS numeLiceu FROM {_NumeTabelProfesor} P, {_NumeTabelLiceu} L, {_NumeTabelRepartizare} R " +
                                                          $"WHERE L.idLiceu = R.idLiceu AND P.idProfesor = R.idProfesor AND Upper(P.nume) like '%{nume.ToUpper()}%' AND Upper(P.prenume) like '%{prenume.ToUpper()} AND L.idLiceu = :idLiceu", CommandType.Text,
                                                            new OracleParameter(":idLiceu", OracleDbType.Int32, l, ParameterDirection.Input));
            return dsPrograme;
        }
        #endregion
    
    }

}
