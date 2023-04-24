using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureAttributes.ViewModel
{
    public class DataSurfaceLoad
    {

        //Permanent Area Load
        public double cm { get; set; }
        public string Material { get; set; }
        public double KgM2Cm { get; set; }
        public int Index { get; set; }

        //Imposed Area Load
        public bool Check { get; set; }
        public string LoadType { get; set; }
        public double KNM2 { get; set; }
    }
}
