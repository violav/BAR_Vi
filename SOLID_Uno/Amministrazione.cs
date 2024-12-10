using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    public class Amministrazione :BaseClass
    {
        public Stipendio CalcolaStipendio(T personale) 
        { 
            double anniLavorati = 0;
            double coefficiente = 0;
            double pagaBase = 0;
            double stipendioNetto = 0;

            switch (personale.GetType()) 
            {
                case typeof(Cameriere):

                    double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select anzianitaLavorativa from db.Personale where idPersona = " + Id), out anniLavorati);
                    double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select coefficiente from db.Calcolo where tipo = 'stipendio' and mansione = 'barista' "), out coefficiente);
                    double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select pagaBase from db.Calcolo where tipo = 'stipendio' and mansione = 'barista' "), out pagaBase);

                    stipendioNetto = pagaBase + anniLavorati* coefficiente;

                    if (stipendioNetto > 0) { return new Stipendio() { StipendioMensileNetto = stipendioNetto }};
                    break;
                case typeof(Barista):

                    double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select anzianitaLavorativa from db.Personale where idPersona = " + Id), out anniLavorati);
                    double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select coefficiente from db.Calcolo where tipo = 'stipendio' and mansione = 'barista' "), out coefficiente);
                    double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select pagaBase from db.Calcolo where tipo = 'stipendio' and mansione = 'barista' "), out pagaBase);

                    stipendioNetto = pagaBase + anniLavorati* coefficiente;

                    if (stipendioNetto > 0) { return new Stipendio() { StipendioMensileNetto = stipendioNetto }};
                break;
                    default:
                    return null;
                break;

            }
            return null;
        }

        public void EmettiOrdine()
        {
            //pago la fattura e lo scrivo da qualche parte
        }
        public void FatturaPassiva() 
        {
            //pago la fattura e lo scrivo da qualche parte
        }

        public void EmettiFattura()
        {
            //mando la fattura e lo scrivo da qualche parte
            stampa.CreaDocumento("fatturaAttiva");
        }

        public void AssumiPersonale()
        {
            //registra all'inps,
            //fai il contratto
            stampa.CreaDocumento("contratto");
            //raccogli i dati
        }
    }
}
