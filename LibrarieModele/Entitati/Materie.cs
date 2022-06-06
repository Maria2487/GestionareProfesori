using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Materie
    {
        public int idMaterie { get; set; }
        public string nume { get; set; }


        public Materie() { }

        public Materie(string nume, int idMaterie = 0)
        {
            this.idMaterie = idMaterie;
            this.nume = nume;
        }

        public Materie(DataRow linieDB)
        {
            this.idMaterie = Convert.ToInt32(linieDB["idMaterie"]);
            this.nume = linieDB["nume"].ToString();
        }
    }
}
