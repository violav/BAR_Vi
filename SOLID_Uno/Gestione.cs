using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class Gestione :BaseClass
    {
        public void ApprovvigionamentoBevande(int quantitaRichiesta)
        {
            Bevanda bev = new Bevanda(1);
            Amministrazione adm = new Amministrazione();

            int quantitaBevanda = 0;
            if (quantitaBevanda <= quantitaRichiesta) 
            {
                adm.EmettiOrdine();
                adm.FatturaPassiva();
            }
            //..
        }

        public void ApprovvigionamentoBevande() 
        {
            int staPerfinireLaBevanda = 0; // da database leggo la soglia della bevanda
            ApprovvigionamentoBevande(staPerfinireLaBevanda);
        }
    }
}
