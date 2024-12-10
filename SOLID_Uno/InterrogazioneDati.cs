using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class InterrogazioneDati
    {
        public string EseguiSelectQueryScalar(string query) { return EseguiSelectQuery(query).Rows[0][0].ToString(); }

        public System.Data.DataTable EseguiSelectQuery(string query) { return new System.Data.DataTable; }
        public void EseguiQuery(string query) { 
            //esegue queryDB
        }
    }
}
