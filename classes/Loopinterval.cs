using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDomein
{
    public class Loopinterval
    {
        public Loopinterval(int sequentieNR, int tijdsduur, double gemSnelheid)
        {
            ZetSequentieNR(sequentieNR);
            ZetTijdsduur(tijdsduur);
            ZetSnelheid(gemSnelheid);
        }
       

        public int SequentieNR { get; private set; }
        public int Tijdsduur { get; private set; }
        public double LoopSnelheid { get; private set; }

        public void ZetSequentieNR(int sequentieNR)
        {
            if(sequentieNR <= 0)
            {
                throw new FitnessDomeinException("Sequentienummer moet groter zijn dan 0");
            }
            SequentieNR = sequentieNR;
        }
        public void ZetTijdsduur(int tijdsduur)
        {
            if(tijdsduur < 5 || tijdsduur > 10800)
            {
                throw new FitnessDomeinException("tijdsduur kan niet korter zijn dan 5sec en niet langer dan 3uur");
            }
            Tijdsduur = tijdsduur;
        }
        public void ZetSnelheid(double loopSnelheid)
        {
            if(loopSnelheid < 5 || loopSnelheid > 22)
            {
                throw new FieldAccessException("loopsnelheid kan niet trager zijn dan 5 km/u en niet sneller dan 22 km/u");
            }
            LoopSnelheid = loopSnelheid;
        }
        public override string ToString()
        {
            return $"SeqNr:{SequentieNR},Snelheid:{LoopSnelheid},Duur:{Tijdsduur}";
        }
    }
}
