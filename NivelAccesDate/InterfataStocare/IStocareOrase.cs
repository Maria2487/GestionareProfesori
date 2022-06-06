using System.Collections.Generic;
using System.Data;
using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareOrase : IStocareFactory
    {
        bool AddOras(Oras o);
        bool UpdateOras(Oras o);
        bool DeleteOras(Oras o);


        Oras GetOras(int id);
        List<Oras> GetOrase();
        
    }
}
