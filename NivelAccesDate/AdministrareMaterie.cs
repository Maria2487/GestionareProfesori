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
    public class AdministrareMaterie : IStocareMaterie
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddMaterie(Materie m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Materie_CotofrecM31 VALUES (seq_Materie_CotofrecM31, :nume)", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, m.nume, ParameterDirection.Input));
        }

        public Materie GetMaterie(int id)
        {
            Materie result = null;
            var dsMaterii = SqlDBHelper.ExecuteDataSet("select * from Materie_CotofrecM31 where idMaterie = :idMaterie", CommandType.Text,
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
            var dsMaterii = SqlDBHelper.ExecuteDataSet("select * from Materie_CotofrecM31", CommandType.Text);

            foreach (DataRow linieDB in dsMaterii.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Materie(linieDB));
            }
            return result;
        }

        public bool UpdateMaterie(Materie m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Materie_CotofrecM31 set nume = :nume, where idMaterie = :idMaterie", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, m.nume, ParameterDirection.Input));
        }
    }
}
