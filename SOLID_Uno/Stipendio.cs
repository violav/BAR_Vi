using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    //sw : ogni parte è di interesse di una figura dievera.
    /// <summary>
    ///  se modifico la parte dei cedolini dei dipendenti e inroduco un bug perchè ho ua formula sbagliata => quella parte deve essere 
    ///  l'unica interessata dal problema.
    /// Se invece il bug si propaga alla pare che li invia via mail: allora si arrabbia sia il CFO che il CTO
    /// Questa è la differenza che è stato implementato che il SRP da uno a spaghetti con il codice troppo accoppiato
    /// Se rompo la classe in quanti si arrabbiano?? Se si arabbiano tre dipartimenit diversi è come se il design mi imlorasse di 
    /// usare tre parti. Non buono. Devo delineare i perimetri delle varie classi in base al nome di chi si arrabbia
    /// 
    /// ALTRO ESEMPIO: web devo fare un'applicazione web. Front end + backend + database. Se si rompe il db ho un bug solo nel 
    /// componente del db. Se si rompe il frontend il backend continua a funzionare. Devo avere tutto ben separato in modo che 
    /// il codice frnt end sia gestito dai frontenders. Posso testare modificare indipendentemente, fare benchmark indipendentemente.
    /// Questo si ottiene dividendo la proprietà del codice: se si rompe il frontend il frontender si arrabbia, e così via.
    /// </summary>
   

    public class Stipendio 
    {
        public double detrazioneIrepf;
        public double Iva;
        public double tasse;
        public double PagaOrariaLorda;
        public double PagaOrariaNetta;
        public double StipendioMensileNetto;
    }
}
