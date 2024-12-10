using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class Stampe : BaseClass
    {
        public void CreaDocumento(string tipoDocumento) 
        {
            //trova i dati di fattra 
            //metti il modello sullabase di tipoDocumento
            Print();
            //ritorna il pdf
        }

        private void Print() { }
    }
}
