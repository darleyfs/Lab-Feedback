using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Feedback
{
    internal class Result
    { 
        public string Timestamp { get; }
        public int Number { get; }

        public Result(string timestamp, int number)
        {
            Timestamp = timestamp;
            Number = number;
        }

        public override string ToString()
        {
            return $"Timestamp: {Timestamp}, Number: {Number}";
        }
    }
}
