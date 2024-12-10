using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
   public  class HR :BaseClass
    {
        public void ReclutaPersonale()
        {
            Amministrazione adm = new Amministrazione();
            //colloquio
            //se va male KO
            //se va bne assumi
            adm.AssumiPersonale();
        }
    }
}
