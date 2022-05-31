using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareProfesori : IStocareFactory
    {
        List<Profesor> GetProfesori();
        Profesor GetProfesor(int id);
        bool AddProfesor(Profesor p);

        bool UpdateProfesor(Profesor p);
        bool DeleteProfesor(int p);
        bool DeleteProfesorDupaMaterie(int m);

        DataSet GetDetaliiProfesori();
    }
}
