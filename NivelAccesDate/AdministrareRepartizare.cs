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
    public class AdministrareRepartizare : IStocareRepartizari
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public bool AddRepartizare(Repartizare r)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Repartizari_CotofrecM31 VALUES (:idProfesor, :idLiceu)", CommandType.Text,
                new OracleParameter(":idProfesor", OracleDbType.Int32, r.idProfesor, ParameterDirection.Input),
                new OracleParameter(":idLiceu", OracleDbType.Int32, r.idLiceu, ParameterDirection.Input));
        }

        public Repartizare GetRepartizare(int idP, int idL)
        {
            Repartizare result = null;
            var dsRepartizari = SqlDBHelper.ExecuteDataSet("select * from Repartizari_CotofrecM31 where idProfesor = :idProfesor AND idLiceu = :idLiceu", CommandType.Text,
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
            var dsRepartizari = SqlDBHelper.ExecuteDataSet("select * from Repartizari_CotofrecM31", CommandType.Text);

            foreach (DataRow linieDB in dsRepartizari.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Repartizare(linieDB));
            }
            return result;
        }

        public bool UpdateRepartizare(Repartizare r, int idLiceuVechi)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Repartizari_CotofrecM31 set idLiceu = :idLiceu where idProfesor = :idProfesor AND idLiceu = :idLiceuVechi", CommandType.Text,
                new OracleParameter(":idLiceu", OracleDbType.Int32, r.idLiceu, ParameterDirection.Input));
        }
    }

}
