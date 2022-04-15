using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDomein
{
    public class FitnessDomeinException : Exception
    {
        // : exception
        //FitnessDomeinException(string message) : base(message)





        //sesnr, duur, gem v, datum, klntnr
        //sortedlst in loopint
        //looptraining => alle methods
        //zetsessienr,zetduur,zetgem v, zetklntnr, ireadonlylist<loopint>{.values.asreadonly} geef intervals, voegintervl toe (gn dubbels), tostring()
        public FitnessDomeinException(string message) : base(message)
        {
        }

        public FitnessDomeinException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
