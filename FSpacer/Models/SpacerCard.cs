using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSpacer.Models
{
    public class SpacerCard
    {
        public int ID { get; set; }
        public string size { get; set; }
        public DateTime date { get; set; }
        public string OperatorID { get; set; }
        public bool Active { get; set; }
        public string Ratio { get; set; }
        public string DriveNumber { get; set; }
        public string GearNumber { get; set; }
        public string HorizontalGearCaseDeviation { get; set; }
        public string HorizontalCarrierDeviation { get; set; }
        public string Bearing { get; set; }
        public string HorizontalMDGear { get; set; }
        public string HorizontalSpacerLength { get; set; }
        public string VerticalGearCaseDeviation { get; set; }
        public string VerticalCarrierBearingDeviation { get; set; }
        public string GearMount { get; set; }
        public string VerticalMDGear { get; set; }
        public string VerticalSpacerLength { get; set; }
        public string Backlash { get; set; }
        public string HorizontalSetting { get; set; }
        public string IntermediateSetting { get; set; }
        public string OutputSetting { get; set; }
        public string HelicalGearNumber { get; set; }
        public string HelicalPinionNumber { get; set; }

        public static string GetHorizontalSpacerLength(int Model, int HorizontalGearCaseDeviation, int HorizontalCarrierDeviation, int Bearing, double HorizontalMDGear)
        {
            string HorizontalSpacerLength = "";

            return HorizontalSpacerLength;
        }


        public static string GetVerticalSpacerLength(int Model, int VerticalGearCaseDeviation, int VerticalCarrierDeviation, double VMDGear, double GearMount)
        {
            string VerticalSpacerLength = "";

            return VerticalSpacerLength;
        }
        
        public static int ModelToInt(string Model)
        {
            int Convert = 0;

            return Convert;
        }

        //public string Size { get; set; }
        //public string Ratio { get; set; }

        //public string GearNumber { get; set; }
        //public string IntermediateSetting { get; set; }



    }
}
