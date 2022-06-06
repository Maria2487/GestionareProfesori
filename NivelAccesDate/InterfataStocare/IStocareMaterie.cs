using System.Collections.Generic;
using System.Data;
using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareMaterie : IStocareFactory
    {
        bool AddMaterie(Materie m);
        bool UpdateMaterie(Materie m);
        bool DeleteMaterie(Materie m);


        Materie GetMaterie(int id);
        List<Materie> GetMaterii();
       
    }
}
