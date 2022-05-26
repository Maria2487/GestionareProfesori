using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace NivelAccesDate
{
    public class AdministrareOras : IStocareOrase
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public bool AddOras(Oras o)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Orase_CotofrecM31 VALUES (seq_Orase_CotofrecM31.nextval, :nume)", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, o.nume, ParameterDirection.Input));
        }

        public Oras GetOras(int id)
        {
            Oras result = null;
            var dsOrase = SqlDBHelper.ExecuteDataSet("select * from Orase_CotofrecM31 where idOras = :idOras", CommandType.Text,
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
            var dsOrase = SqlDBHelper.ExecuteDataSet("select * from Orase_CotofrecM31", CommandType.Text);

            foreach (DataRow linieDB in dsOrase.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Oras(linieDB));
            }
            return result;
        }

        public bool UpdateOras(Oras o)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Orase_CotofrecM31 set nume = :nume where idOras = :idOras", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, o.nume, ParameterDirection.Input));
        }
    }
}
