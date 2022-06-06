using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Repartizare
    {
        public int idProfesor { get; set; }
        public int idLiceu { get; set; }


        public Repartizare() { }

        public Repartizare(int idProfesor, int idLiceu)
        {
            this.idProfesor = idProfesor;
            this.idLiceu = idLiceu;
        }

        public Repartizare(DataRow linieDB)
        {
            this.idProfesor = Convert.ToInt32(linieDB["idProfesor"]);
            this.idLiceu = Convert.ToInt32(linieDB["idLiceu"]);
        }
    }
}
