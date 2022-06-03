using LibrarieModele;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public class AdministrareLiceu : IStocareLicee
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        private readonly string _NumeTabelLiceu = ConfigurationManager.AppSettings.Get("K_NumeTabelLiceu");
        private readonly string _NumeTabelMaterii = ConfigurationManager.AppSettings.Get("K_NumeTabelMaterii");
        private readonly string _NumeTabelOras = ConfigurationManager.AppSettings.Get("K_NumeTabelOras");
        private readonly string _NumeTabelProfesor = ConfigurationManager.AppSettings.Get("K_NumeTabelProfesor");
        private readonly string _NumeTabelRepartizare = ConfigurationManager.AppSettings.Get("K_NumeTabelRepartizare");
        private readonly string _SecventaTabelLiceu = ConfigurationManager.AppSettings.Get("K_SecventaTabelLiceu");
        private readonly string _SecventaTabelMaterie = ConfigurationManager.AppSettings.Get("K_SecventaTabelMaterie");
        private readonly string _SecventaTabelOras = ConfigurationManager.AppSettings.Get("K_SecventaTabelOras");
        private readonly string _SecventaTabelProfesor = ConfigurationManager.AppSettings.Get("K_SecventaTabelProfesor");


        public bool AddLiceu(Liceu l)
        {
            return SqlDBHelper.ExecuteNonQuery(
                 $"INSERT INTO {_NumeTabelLiceu} VALUES ({_SecventaTabelLiceu}.NEXTVAL, :nume, :idOras)", CommandType.Text,
                 new OracleParameter(":nume", OracleDbType.Varchar2, l.nume, ParameterDirection.Input),
                 new OracleParameter(":idOras", OracleDbType.Int32, l.IdOras, ParameterDirection.Input));
        }

        public List<Liceu> GetLicee()
        {
            var result = new List<Liceu>();
            var dsLicee = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelLiceu}", CommandType.Text);

            foreach (DataRow linieDB in dsLicee.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Liceu(linieDB));
            }
            return result;
        }

        public Liceu GetLiceu(int id)
        {
            Liceu result = null;
            var dsLicee = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelLiceu} where idLiceu = :idLiceu", CommandType.Text,
                new OracleParameter(":idLiceu", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsLicee.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsLicee.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Liceu(linieDB);
            }
            return result;
        }

        public bool UpdateLiceu(Liceu l)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_NumeTabelLiceu} set nume = :nume, idOras = :idOras where idLiceu = :idLiceu", CommandType.Text,
                 new OracleParameter(":nume", OracleDbType.Varchar2, l.nume, ParameterDirection.Input),
                 new OracleParameter(":idOras", OracleDbType.Int32, l.IdOras, ParameterDirection.Input),
                 new OracleParameter(":idLiceu", OracleDbType.Int32, l.IdLiceu, ParameterDirection.Input)
                 );
        }

        public bool DeleteLiceu( int l)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelLiceu} WHERE idLiceu = :idLiceu", CommandType.Text,
                    new OracleParameter(":idLiceu", OracleDbType.Int32, l, ParameterDirection.Input));
        }

        public DataSet GetDetaliiLicee()
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT L.idLiceu, L.nume AS numeLiceu, O.idOras, O.nume AS numeOras FROM {_NumeTabelLiceu} L, {_NumeTabelOras} O WHERE L.idLiceu = idLiceu AND O.idOras = L.idOras", CommandType.Text);
            return dsPrograme;
        }

        public DataSet GetDetaliiLiceeDupaDenumireSiOras(int o, string str)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT L.idLiceu, L.nume AS numeLiceu, O.idOras, O.nume AS numeOras " +
                                                        $"FROM {_NumeTabelLiceu} L, {_NumeTabelOras} O " +
                                                        $"WHERE O.idOras = L.idOras AND L.idOras = :idOras AND L.nume like '%{str}%'", CommandType.Text,
                                                        new OracleParameter(":idOras", OracleDbType.Int32, o, ParameterDirection.Input));
            return dsPrograme;
        }

        public DataSet GetDetaliiLiceeDupaDenumire(string str)
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT L.idLiceu, L.nume AS numeLiceu, O.idOras, O.nume AS numeOras " +
                                                        $"FROM {_NumeTabelLiceu} L, {_NumeTabelOras} O " +
                                                        $"WHERE O.idOras = L.idOras AND L.nume like '%{str}%'", CommandType.Text);
            return dsPrograme;
        }
    }
}




