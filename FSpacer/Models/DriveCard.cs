using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSpacer.Models
{
    public class DriveCard
    {
        public int ID { get; set; }
        public string Model {get; set;}
        public string DriveNumber { get; set; }
        public string GearNumber { get; set; }
        public string Ratio { get; set; }
    }
}
