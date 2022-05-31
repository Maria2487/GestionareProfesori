using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Liceu
    {
        public int IdLiceu { get; set; }
        public string nume { get; set; }
        public int IdOras { get; set; }

        public Liceu(string nume, int idOras, int idLiceu = 0)
        {
            this.IdLiceu = idLiceu;
            this.nume = nume;
            this.IdOras = idOras;
        }

        public Liceu() { }

        public Liceu(DataRow linieDB)
        {
            this.IdLiceu = Convert.ToInt32(linieDB["idLiceu"]);
            this.nume = linieDB["nume"].ToString();
            this.IdOras = Convert.ToInt32(linieDB["idOras"]);
        }
    }
}
