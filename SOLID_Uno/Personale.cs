using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uno
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Personale : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }

        private string _mansione { get; set; }
        public double CalcolaGiorniFerie()
        {
            double giorniFerieConsumati = 0;
            double result = 0;
            double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select ferieGodute from db.Personale where idPersona = 0"), out giorniFerieConsumati);

            if (_mansione == "cameriere") { result = 30 - giorniFerieConsumati; }
            else if (_mansione == "barista") { result = 28 - giorniFerieConsumati; }
            else result = 0;

            if (result > 0) { return result; }
            else return 0;
        }

        public double CalcolaStipendio()
        {
            double anniLavorati = 0;
            double coefficiente = 0;
            double pagaBase = 0;

            double result = 0;
            double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select anzianitaLavorativa from db.Personale where idPersona = " + Id), out anniLavorati);
            double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select coefficiente from db.Calcolo where tipo = 'stipendio' and mansione = 'barista' " ), out coefficiente);
            double.TryParse(interrogazioneDati.EseguiSelectQueryScalar("select pagaBase from db.Calcolo where tipo = 'stipendio' and mansione = 'barista' "), out pagaBase);

           result = pagaBase + anniLavorati * coefficiente; 
         
            if (result > 0) { return result; }
            else return 0;

        }

        public Personale(int Id) {
            System.Data.DataTable dtDati = interrogazioneDati.EseguiSelectQuery("select * from db.Personale where idPersona = " + Id);

        }
    }
}
