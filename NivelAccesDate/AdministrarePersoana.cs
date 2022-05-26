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
    public class AdministrarePersoana : IStocareProfesori
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public bool AddProfesor(Profesor p)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO Profesori_CotofrecM31 VALUES (seq_Profesori_CotofrecM31.nextval, :nume, :prenume, :idMaterie)", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, p.nume, ParameterDirection.Input),
                new OracleParameter(":prenume", OracleDbType.NVarchar2, p.prenume, ParameterDirection.Input),
                new OracleParameter(":idMaterie", OracleDbType.Int32, p.idMaterie, ParameterDirection.Input));
        }

        public Profesor GetProfesor(int id)
        {
            Profesor result = null;
            var dsProfesori = SqlDBHelper.ExecuteDataSet("select * from Profesori_CotofrecM31 where idProfesor = :idProfesor", CommandType.Text,
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
            var dsProfesori = SqlDBHelper.ExecuteDataSet("select * from Profesori_CotofrecM31", CommandType.Text);

            foreach (DataRow linieDB in dsProfesori.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Profesor(linieDB));
            }
            return result;
        }

        public bool UpdateProfesor(Profesor p)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Profesori_CotofrecM31 set nume = :nume, prenume = :prenume, idMaterie = :idMaterie where idProfesor = :idProfesor", CommandType.Text,
                new OracleParameter(":nume", OracleDbType.NVarchar2, p.nume, ParameterDirection.Input),
                new OracleParameter(":prenume", OracleDbType.NVarchar2, p.prenume, ParameterDirection.Input),
                new OracleParameter(":idMaterie", OracleDbType.Int32, p.idMaterie, ParameterDirection.Input));
        }
    }
}
