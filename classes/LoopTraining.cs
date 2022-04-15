using System;
using System.Collections.Generic;

namespace FitnessDomein
{
    public class LoopTraining
    {
        public LoopTraining(int sessieNr, DateTime datum, int klantNr, int totTrainingsDuur, double gemSnelheid)
        {
            ZetSessieNr(sessieNr);
            ZetKlantNr(klantNr);
            Datum = datum;
            ZetTotTrainingsDuur(totTrainingsDuur);
            ZetGemSnelheid(gemSnelheid);
        }

        public int SessieNr { get;private set; }
        public DateTime Datum { get; private set; }
        public int KlantNr { get; private set; }
        public int TotTrainingsDuur { get; private set; }
        public double GemSnelheid { get; private set; }
        public virtual int Count { get; }

        SortedList<int, Loopinterval> Intervals = new SortedList<int, Loopinterval>();

        public void ZetSessieNr(int sessieNr)
        {
            if(sessieNr <= 0)
            {
                throw new FitnessDomeinException("Sessienummer mag niet kleiner zijn dan of gelijk zijn aan 0");
            }
            SessieNr = sessieNr;
        }
        public void ZetKlantNr(int klantNr)
        {
            if (klantNr <= 0)
            {
                throw new FitnessDomeinException("Klantnummer mag niet kleiner zijn dan of gelijk aan 0");
            }
            KlantNr = klantNr;
        }
        public void ZetTotTrainingsDuur(int totTrainingsDuur)
        {
            if (totTrainingsDuur < 5 || totTrainingsDuur > 180)
            {
                throw new FitnessDomeinException("De totale trainingsduur mag niet korter zijn dan 5 min en niet langer dan 3 uur");
            }
            TotTrainingsDuur = totTrainingsDuur;
        }
        public void ZetGemSnelheid(double gemSnelheid)
        {
            if (gemSnelheid < 5 || gemSnelheid > 22)
            {
                throw new FitnessDomeinException("Gemiddelde snelheid mag niet lager zijn dan 5 km/u en niet hoger dan 22 km/u");
            }
            GemSnelheid = gemSnelheid;
        }
        public IReadOnlyList<Loopinterval> GeefIntervals()
        {
            List<Loopinterval> lijst = new List<Loopinterval>();
            foreach(Loopinterval interval in Intervals.Values)
            {
                lijst.Add(interval);
            }
            IReadOnlyList<Loopinterval> readOnly = lijst;
            return readOnly;
        }
        public void VoegIntervalToe(Loopinterval interval)
        {
            int index = 0;
            while (true)
            {
                if (!Intervals.ContainsKey(index))
                {
                    Intervals.Add(index, interval);
                    break;
                }
                index++;
            }
        }
        public override string ToString()
        {
            
            string s = $"Sessie:{SessieNr},Datum:{Datum},Klant:{KlantNr},Duur:{TotTrainingsDuur},Snelheid:{GemSnelheid},Intervals:{Intervals.Values.Count}";
            foreach(Loopinterval li in Intervals.Values)
            {
                s += $"\n    {li.ToString()}";
            }
            return s;
        }
    }
}
