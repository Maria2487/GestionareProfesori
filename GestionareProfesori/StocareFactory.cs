using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using LibrarieModele;

namespace GestionareProfesori
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Liceu))
                        {
                            return new AdministrareLiceu();
                        }
                        if (tipEntitate == typeof(Materie))
                        {
                            return new AdministrareMaterie();
                        }
                        if (tipEntitate == typeof(Oras))
                        {
                            return new AdministrareOras();
                        }
                        if (tipEntitate == typeof(Profesor))
                        {
                            return new AdministrareProfesori();
                        }
                        if (tipEntitate == typeof(Repartizare))
                        {
                            return new AdministrareRepartizare();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
