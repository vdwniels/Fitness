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

        public List<LoopTraining> OverzichtTraining(Dictionary<int, LoopTraining> training, int klantnr)
        {
            List<LoopTraining> trainingen = new List<LoopTraining>();
            foreach(LoopTraining lt in training.Values)
            {
                if(lt.KlantNr == klantnr)
                {
                    Console.WriteLine(lt.ToString());
                }
            }
            return trainingen;
        }
    }
}
