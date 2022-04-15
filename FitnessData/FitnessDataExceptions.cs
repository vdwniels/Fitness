using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessData
{
    class FitnessDataExceptions : Exception
    {
        public FitnessDataExceptions(string message) : base(message)
        {
        }

        public FitnessDataExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
