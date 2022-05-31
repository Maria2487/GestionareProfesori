using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public struct CautaElement
    {
        private string columnName;
        private string value;

        public string ColumnName { get { return columnName; } }
        public string Value { get { return value; } }

        /// <summary>
        /// Struct pentru a prelua coloana si valoarea din -datagridview- pentru search
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="value"></param>
        public CautaElement(string columnName, string value)
        {
            this.columnName = columnName;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{columnName} {value}";
        }
    }
}
