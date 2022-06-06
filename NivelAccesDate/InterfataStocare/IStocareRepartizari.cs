using System.Collections.Generic;
using System.Data;
using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareRepartizari : IStocareFactory
    {
        bool AddRepartizare(Repartizare r);
        bool UpdateRepartizare(Repartizare r, int idLiceuVechi);
        bool DeleteRepartizarePentruLiceu(int idLiceu);
        bool DeleteRepartizarePentruProfesor(int idProfesor);
        bool DeleteRepartizare(Repartizare r);


        Repartizare GetRepartizare(int idP, int idL);
        List<Repartizare> GetRepartizari();
        

        DataSet GetDetaliiRepartizari();
        DataSet GetDetaliiCautaRepartizariLiceu(int l);
        DataSet GetDetaliiCautaRepartizariNumeSauPrenume(string tip, string str);
        DataSet GetDetaliiCautaRepartizareNumeSiPrenume(string nume, string prenume);
        DataSet GetDetaliiCautaRepartizare(int l, string nume, string prenume);

    }
}
