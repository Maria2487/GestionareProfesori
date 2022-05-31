using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public static class Validari
    {
        public static string ValidareDenumire(string str)
        {
            if(str == string.Empty)
            {
                return "Denumirea nu trebuie sa lipseasca";
            }
            if (ContineCifre(str) == true)
            {
                return "Denumirea nu poate contine cifre";
            }
            string special;
            if(ContineCaractereSpeciale(str, out special) == true)
            {
                return $"Denumirea nu poate contine caracterele: {special}";
            }
            return "SUCCES";
        }

        public static bool ContineCifre(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContineCaractereSpeciale(string str, out string caractere)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string caractereSpeciale = "!@#$%^&*()_=+/\\<>?;:'";

            foreach (char caracterSpecial in caractereSpeciale)
            {
                if (str.IndexOf(caracterSpecial) != -1)
                    stringBuilder.Append(caracterSpecial);
            }
            caractere = stringBuilder.ToString();
            return stringBuilder.Length > 0 ? true : false;
        }

    }
}
