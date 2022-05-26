using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Oras
    {
        public int idOras { get; set; }
        public string nume { get; set; }

        public Oras(string nume, int idOras = 0)
        {
            this.idOras = idOras;
            this.nume = nume;
        }

        public Oras() { }

        public Oras(DataRow linieDB)
        {
            this.idOras = Convert.ToInt32(linieDB["idOras"]);
            this.nume = linieDB["nume"].ToString();
        }
    }
}
