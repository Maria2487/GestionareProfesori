using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareRepartizari : IStocareFactory
    {
        List<Repartizare> GetRepartizari();
        Repartizare GetRepartizare(int idP, int idL);
        bool AddRepartizare(Repartizare r);

        bool UpdateRepartizare(Repartizare r, int idLiceuVechi);
        bool DeleteRepartizarePentruLiceu(int idLiceu);
        bool DeleteRepartizarePentruProfesor(int idProfesor);
        bool DeleteRepartizare(Repartizare r);

    }
}
