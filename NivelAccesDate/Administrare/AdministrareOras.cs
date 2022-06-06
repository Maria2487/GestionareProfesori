using LibrarieModele;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Data;
using System.Configuration;

namespace NivelAccesDate
{
    public class AdministrareOras : IStocareOrase
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        private readonly string _NumeTabelOras = ConfigurationManager.AppSettings.Get("K_NumeTabelOras");
        private readonly string _SecventaTabelOras = ConfigurationManager.AppSettings.Get("K_SecventaTabelOras");


        public bool AddOras(Oras o)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO {_NumeTabelOras} VALUES ({_SecventaTabelOras}.nextval, :nume)", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, o.nume, ParameterDirection.Input));
        }
        public bool UpdateOras(Oras o)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"UPDATE {_NumeTabelOras} set nume = :nume where idOras = :idOras", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, o.nume, ParameterDirection.Input),
                new OracleParameter(":idOras", OracleDbType.NVarchar2, o.idOras, ParameterDirection.Input));
        }
        public bool DeleteOras(Oras o)
        {
            return SqlDBHelper.ExecuteNonQuery(
                    $"DELETE FROM {_NumeTabelOras} WHERE idOras = :idOras", CommandType.Text,
                    new OracleParameter(":idOras", OracleDbType.Int32, o.idOras, ParameterDirection.Input));
        }
       
        
        public Oras GetOras(int id)
        {
            Oras result = null;
            var dsOrase = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelOras} where idOras = :idOras", CommandType.Text,
                new OracleParameter(":idOras", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsOrase.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsOrase.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Oras(linieDB);
            }
            return result;
        }
        public List<Oras> GetOrase()
        {
            var result = new List<Oras>();
            var dsOrase = SqlDBHelper.ExecuteDataSet($"select * from {_NumeTabelOras}", CommandType.Text);

            foreach (DataRow linieDB in dsOrase.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Oras(linieDB));
            }
            return result;
        }

    }
}
