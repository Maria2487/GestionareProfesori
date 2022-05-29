using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Configuration;

namespace NivelAccesDate
{
    public class AdministrareMaterie : IStocareMaterie
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

        public bool AddMaterie(Materie m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_NumeTabelMaterii} VALUES ({_SecventaTabelMaterie}.NEXTVAL, :nume)", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, m.nume, ParameterDirection.Input));
        }

        public Materie GetMaterie(int id)
        {
            Materie result = null;
            var dsMaterii = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelMaterii} where idMaterie = :idMaterie", CommandType.Text,
                new OracleParameter(":idMaterie", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsMaterii.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsMaterii.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Materie(linieDB);
            }
            return result;
        }

        public List<Materie> GetMaterii()
        {
            var result = new List<Materie>();
            var dsMaterii = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelMaterii}", CommandType.Text);

            foreach (DataRow linieDB in dsMaterii.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Materie(linieDB));
            }
            return result;
        }

        public bool UpdateMaterie(Materie m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_NumeTabelMaterii} set nume = :nume, where idMaterie = :idMaterie", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, m.nume, ParameterDirection.Input),
                new OracleParameter(":idMaterie", OracleDbType.NVarchar2, m.idMaterie, ParameterDirection.Input));
        }

        public bool DeleteMaterie(Materie m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelMaterii} WHERE idMaterie = :idMaterie", CommandType.Text,
                    new OracleParameter(":idMaterie", OracleDbType.Int32, m.idMaterie, ParameterDirection.Input));
        }
    }
}
