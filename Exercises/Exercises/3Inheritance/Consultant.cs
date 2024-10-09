using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3Inheritance
{
    class Consultant : Person
    {
        public Consultant(string name, decimal HourlyRate, int HoursReported) : base(name)
        {
            this.HourlyRate = HourlyRate;
            this.HoursReported = HoursReported;
        }

        public decimal HourlyRate { get; set; }
        public int HoursReported { get; set; }
    }
}
