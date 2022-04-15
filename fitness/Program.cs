using System;
using System.Collections.Generic;
using System.IO;
using FitnessData;
using FitnessDomein;
namespace fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            // path: C:\Users\niels\OneDrive\Documenten\progr gevorderd\fitness\insertRunning (1)
            Dictionary<int, LoopTraining> training = new Dictionary<int, LoopTraining>();

            string logpad = @"C:\Users\niels\OneDrive\Documenten\progr gevorderd\fitness\insertRunning (3)";
            string logbestandsnaam = "insertRunningLog.txt";
            string bronpad = @"C:\Users\niels\OneDrive\Documenten\progr gevorderd\fitness\insertRunning (3)";
            string bronbestandsnaam = "insertRunningTest.txt";

            string loglocatie = Path.Combine(logpad, logbestandsnaam);
            string bronlocatie = Path.Combine(bronpad, bronbestandsnaam);
            Bestandverwerker b = new Bestandverwerker();
            //training = b.LeesBestand(loglocatie,bronlocatie);
            LoopTraining lt = new LoopTraining(1, new DateTime(2021, 9, 29, 16, 53, 00), 2, 55, 14);
            Loopinterval li1 = new Loopinterval(1,50,15);
            Loopinterval li2 = new Loopinterval(2, 55, 14);
            lt.VoegIntervalToe(li1);
            lt.VoegIntervalToe(li2);
            DataBeheerder db = new DataBeheerder();
            Dictionary<int, LoopTraining> a = new Dictionary<int, LoopTraining>();
            a.Add(1, lt);
            db.OverzichtTraining(a,2);

        }
    }
}
