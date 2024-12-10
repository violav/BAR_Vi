using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class Bar : BaseClass
    {
        public IList<Bevanda>Bbevande { get; set; }
        public IList<Personale> Personale { get; set; }
        public IList<Eventi> Eventi { get; set; }

        public void ApprovvigionaBevande() 
        {
            utils.ApprovvigionamentoBevande();
        }
        public void ReclutaPersonale()
        {
            utils.ReclutaPersonale();
        }
    }
}
