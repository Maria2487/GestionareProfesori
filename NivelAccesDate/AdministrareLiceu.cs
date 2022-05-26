using LibrarieModele;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
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


        public bool AddLiceu(Liceu l)
        {
            return SqlDBHelper.ExecuteNonQuery(
                 "INSERT INTO Liceu_CotofrecM31 VALUES (seq_Liceu_CotofrecM31.NEXTVAL, :nume, :idOras)", CommandType.Text,
                 new OracleParameter(":nume", OracleDbType.Varchar2, l.nume, ParameterDirection.Input),
                 new OracleParameter(":idOras", OracleDbType.Int32, l.IdOras, ParameterDirection.Input));
        }

        public List<Liceu> GetLicee()
        {
            var result = new List<Liceu>();
            var dsLicee = SqlDBHelper.ExecuteDataSet("select * from Liceu_CotofrecM31", CommandType.Text);

            foreach (DataRow linieDB in dsLicee.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Liceu(linieDB));
            }
            return result;
        }

        public Liceu GetLiceu(int id)
        {
            Liceu result = null;
            var dsLicee = SqlDBHelper.ExecuteDataSet("select * from Liceu_CotofrecM31 where idLiceu = :idLiceu", CommandType.Text,
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
                "UPDATE Liceu_CotofrecM31 set nume = :nume, idOras=idOras where idLiceu = :idLiceu", CommandType.Text,
                 new OracleParameter(":nume", OracleDbType.Varchar2, l.nume, ParameterDirection.Input),
                 new OracleParameter(":idOras", OracleDbType.Int32, l.IdOras, ParameterDirection.Input));
        }
    }
}
