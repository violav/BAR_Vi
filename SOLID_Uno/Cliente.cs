using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class Cliente : BaseClass
    {
        public int Nome { get; set; }
        public int ClienteID { get; set; }
        public double CalcolaContoAperto ()
        {
            double totDaPagare = 0;

            double result = 0;
            double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select acquistoNonParato from db.AcquistoCliente where idPersona = " + ClienteID), out totDaPagare);

             return totDaPagare;
        }

        public void Paga(double importo)
        {
            interrogazioneDati.EseguiQuery("update db.AcquistoCliente  set acquistoNonParato = acquistoNonParato - " + importo + " where idPersona = " + ClienteID);
        }
    }
}
