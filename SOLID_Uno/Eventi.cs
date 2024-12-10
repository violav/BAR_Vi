using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class Eventi : BaseClass
    {
        private HR _hr;
        private Gestione _gestione;

        public Eventi()
        {
            _hr = new HR();
            _gestione = new Gestione();
        }

        public void ApprovvigionaBevande()
        {
            _gestione.ApprovvigionamentoBevande();
        }
        public void ReclutaPersonale()
        {
            _hr.ReclutaPersonale();
        }
    }
}
