using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Profesor
    {
        public int idProfesor { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public int idMaterie { get; set; }


        public Profesor() { }

        public Profesor(string nume, string prenume, int idMaterie, int idProfesor = 0)
        {
            this.idProfesor = idProfesor;
            this.nume = nume;
            this.prenume = prenume;
            this.idMaterie = idMaterie;
        }

        public Profesor(DataRow linieDB)
        {
            this.idProfesor = Convert.ToInt32(linieDB["idProfesor"]);
            this.nume = linieDB["nume"].ToString();
            this.prenume = linieDB["prenume"].ToString();
            this.idMaterie = Convert.ToInt32(linieDB["idMaterie"]);
        }
    }
}
