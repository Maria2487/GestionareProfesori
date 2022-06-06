using System.Collections.Generic;
using System.Data;
using LibrarieModele;


namespace NivelAccesDate
{
    public interface IStocareProfesori : IStocareFactory
    {
        bool AddProfesor(Profesor p);
        bool UpdateProfesor(Profesor p);
        bool DeleteProfesor(int p);
        bool DeleteProfesorDupaMaterie(int m);


        Profesor GetProfesor(int id);
        List<Profesor> GetProfesori();
       

        DataSet GetDetaliiProfesori(string str1 = "", string str2 = "");
    }
}
