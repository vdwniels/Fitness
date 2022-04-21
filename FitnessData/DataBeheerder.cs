using FitnessDomein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessData
{
    public class DataBeheerder
    {
        public DataBeheerder()
        {
        }

        public void OverzichtTrainingKlant(Dictionary<int, LoopTraining> training, int klantnr)
        {
            
            foreach(LoopTraining lt in training.Values)
            {
                if(lt.KlantNr == klantnr)
                {
                    Console.WriteLine(lt.ToString());
                }
            }
            
        }
        public void OverzichtTrainingDag(Dictionary<int, LoopTraining> training, DateTime dag)
        {

            foreach (LoopTraining lt in training.Values)
            {
                if (lt.Datum.Day == dag.Day && lt.Datum.Month == dag.Month && lt.Datum.Year == dag.Year )
                {
                    Console.WriteLine(lt.ToString());
                }
            }

        }
    }
}
