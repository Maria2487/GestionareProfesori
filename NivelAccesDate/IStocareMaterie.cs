using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareMaterie : IStocareFactory
    {
        List<Materie> GetMaterii();
        Materie GetMaterie(int id);
        bool AddMaterie(Materie m);

        bool UpdateMaterie(Materie m);
    }
}
