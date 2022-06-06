using System.Collections.Generic;
using System.Data;
using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareLicee : IStocareFactory
    {
        bool AddLiceu(Liceu l);
        bool UpdateLiceu(Liceu l);
        bool DeleteLiceu(int l);


        Liceu GetLiceu(int id);
        List<Liceu> GetLicee();
       

        DataSet GetDetaliiLicee();
        DataSet GetDetaliiLiceeDupaDenumireSiOras(int o, string str);
        DataSet GetDetaliiLiceeDupaDenumire(string str);

    }
}
