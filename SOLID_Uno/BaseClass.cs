using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class BaseClass
    {
        protected InterrogazioneDati interrogazioneDati;
        protected Stampe stampa;

        public BaseClass() 
        {
            interrogazioneDati = new InterrogazioneDati();
            stampa = new Stampe();
        }
    }
}
