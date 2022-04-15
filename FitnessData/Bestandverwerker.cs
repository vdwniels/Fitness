using System;
using System.Globalization;
using System.IO;
using FitnessDomein;
using System.Collections.Generic;
using System.Collections;

namespace FitnessData
{
    public class Bestandverwerker
    {// NOG KLASSES DATABEHEERDER 2dictionairies construvtor met foreach checken op dubbels if contains voor datum-en klantdataEN FITNESSDATAEXCEPTIONS

        public Bestandverwerker()
        {
        }

        public Dictionary<int, LoopTraining> LeesBestand(string logBestandsNaam, string bronbestandsNaam) {
            Dictionary<int, LoopTraining> training = new Dictionary<int, LoopTraining>();

            using (StreamWriter sw = new StreamWriter(logBestandsNaam))
            using (StreamReader sr = new StreamReader(bronbestandsNaam)) {
                /*try
                {*/
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Substring(line.IndexOf("(") + 1, line.IndexOf(")") - line.IndexOf("(") - 1);
                        string[] elementen = line.Split(",");
                        int sessieNr = int.Parse(elementen[0]);
                        DateTime datum = DateTime.Parse(elementen[1].Trim('\''));
                        int klantNr = int.Parse(elementen[2]);
                        int totTrainingsDuur = int.Parse(elementen[3]);
                        double gemSnelheid = Double.Parse(elementen[4], CultureInfo.InvariantCulture);
                        int sequentieNr = int.Parse(elementen[5]);
                        int tijdsduurInterval = int.Parse(elementen[6]);
                        Double loopSnelheid = Double.Parse(elementen[7], CultureInfo.InvariantCulture);
                        try
                        {
                            Loopinterval li = new Loopinterval(sequentieNr, tijdsduurInterval, loopSnelheid);
                            if (training.ContainsKey(sessieNr))
                            {
                                training[sessieNr].VoegIntervalToe(li);
                            }
                            else
                            {
                                LoopTraining lt = new LoopTraining(sessieNr, datum, klantNr, totTrainingsDuur, gemSnelheid);
                                lt.VoegIntervalToe(li);
                                training.Add(sessieNr, lt);
                            }
                        }
                        catch (FitnessDataExceptions fde)
                        {
                            string data = "";
                            foreach (DictionaryEntry d in fde.Data) data += (d.Key.ToString() + ":" + d.Value.ToString());
                            sw.WriteLine(fde.Message + "|" + data);
                        }
                    }


                /*}
                catch(Exception ex)
                
                {
                    sw.WriteLine(ex.Message);
                    throw;
                }*/
                return training;
            }
        }
    }
}
