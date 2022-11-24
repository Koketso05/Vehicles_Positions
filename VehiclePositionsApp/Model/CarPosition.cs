using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConsoleApp.Model
{
    internal class CarPosition
    {
        public int PositionId { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }

        public int RecordedTimeUTC { get; set; }

        public string VehicleRegistration { get; set; }
    }
}
