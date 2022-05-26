using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareLicee : IStocareFactory
    {
        List<Liceu> GetLicee();
        Liceu GetLiceu(int id);
        bool AddLiceu(Liceu l);

        bool UpdateLiceu(Liceu l);
    }
}
