using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Garage.Classes
{
    class Globals
    {
        public static List<Procesor> procesorList = new List<Procesor>();
        public static List<PlacaDeBaza> motherBoardList = new List<PlacaDeBaza>();
        public static List<PlacaVideo> videoCardList = new List<PlacaVideo>();
        public static List<RAM> ramList = new List<RAM>();
        public static List<SSD> ssdList = new List<SSD>();
        public static List<HDD> hddList = new List<HDD>();
        public static List<Sursa> powerUnitList = new List<Sursa>();
        public static List<UnitateOptica> opticalDriveList = new List<UnitateOptica>();

        public static List<PC> pcList = new List<PC>();
        public static List<Regula> ruleList = new List<Regula>();
    }
}
