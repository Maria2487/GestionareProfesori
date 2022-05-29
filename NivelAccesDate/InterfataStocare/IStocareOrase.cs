using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareOrase : IStocareFactory
    {
        List<Oras> GetOrase();
        Oras GetOras(int id);
        bool AddOras(Oras o);

        bool UpdateOras(Oras o);
        bool DeleteOras(Oras o);
    }
}
