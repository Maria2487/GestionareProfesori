using LibrarieModele;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Data;
using System.Configuration;

namespace NivelAccesDate
{
    public class AdministrareProfesori : IStocareProfesori
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        private readonly string _NumeTabelMaterii = ConfigurationManager.AppSettings.Get("K_NumeTabelMaterii");
        private readonly string _NumeTabelProfesor = ConfigurationManager.AppSettings.Get("K_NumeTabelProfesor");
        private readonly string _SecventaTabelProfesor = ConfigurationManager.AppSettings.Get("K_SecventaTabelProfesor");
       
        
        public bool AddProfesor(Profesor p)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_NumeTabelProfesor} VALUES ({_SecventaTabelProfesor}.nextval, :nume, :prenume, :idMaterie)", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, p.nume, ParameterDirection.Input),
                new OracleParameter(":prenume", OracleDbType.NVarchar2, p.prenume, ParameterDirection.Input),
                new OracleParameter(":idMaterie", OracleDbType.Int32, p.idMaterie, ParameterDirection.Input));
        }
        public bool UpdateProfesor(Profesor p)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_NumeTabelProfesor} set nume = :nume, prenume = :prenume, idMaterie = :idMaterie where idProfesor = :idProfesor", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, p.nume, ParameterDirection.Input),
                new OracleParameter(":prenume", OracleDbType.NVarchar2, p.prenume, ParameterDirection.Input),
                new OracleParameter(":idMaterie", OracleDbType.Int32, p.idMaterie, ParameterDirection.Input),
                new OracleParameter(":idProfesor", OracleDbType.Int32, p.idProfesor, ParameterDirection.Input));
        }
        public bool DeleteProfesor(int p)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelProfesor} WHERE idProfesor = :idProfesor", CommandType.Text,
                    new OracleParameter(":idProfesor", OracleDbType.Int32, p, ParameterDirection.Input));
        }
        public bool DeleteProfesorDupaMaterie(int m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelProfesor} WHERE idMaterie = :idMaterie", CommandType.Text,
                    new OracleParameter(":idMaterie", OracleDbType.Int32, m, ParameterDirection.Input));
        }


        public Profesor GetProfesor(int id)
        {
            Profesor result = null;
            var dsProfesori = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelProfesor} where idProfesor = :idProfesor", CommandType.Text,
                new OracleParameter(":idProfesor", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsProfesori.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsProfesori.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Profesor(linieDB);
            }
            return result;
        }
        public List<Profesor> GetProfesori()
        {
            var result = new List<Profesor>();
            var dsProfesori = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelProfesor}", CommandType.Text);

            foreach (DataRow linieDB in dsProfesori.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Profesor(linieDB));
            }
            return result;
        }


        #region Pentru Afisari
        public DataSet GetDetaliiProfesori()
        {
            var dsPrograme = SqlDBHelper.ExecuteDataSet($"SELECT P.idProfesor, P.nume AS numeProfesor, P.prenume, M.idMaterie, M.nume AS numeMaterie FROM {_NumeTabelProfesor} P, {_NumeTabelMaterii} M WHERE P.idMaterie = M.idMaterie", CommandType.Text);
            return dsPrograme;
        }
        #endregion
    }
}
