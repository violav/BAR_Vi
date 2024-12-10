using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class Bevanda :BaseClass
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double  GradoAlcolico { get; set; }
        public double Prezzo { get; set; }

        public Bevanda(int id) 
        {
            Id = id;
            System.Data.DataTable dt = interrogazioneDati.EseguiSelectQuery("select * from db.bevande where id = " + id);
            Nome = dt.Rows[0]["nome"].ToString();
            GradoAlcolico = double.Parse( dt.Rows[0]["gradoAlcolico"].ToString());
            Prezzo = double.Parse(dt.Rows[0]["Prezzo"].ToString());
        }
    }
}
