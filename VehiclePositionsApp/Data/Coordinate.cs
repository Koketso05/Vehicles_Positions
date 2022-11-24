using ListConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConsoleApp.Data
{
    internal static class CoordinateCollection
    {

        public static List<Coordinate> CoordinateList = new List<Coordinate>() {
            new Coordinate { Position = 2, Latitude = 32.345544f, Longitude = -99.123124f},
            new Coordinate { Position = 3, Latitude = 33.234235f, Longitude = -100.214124f},
            new Coordinate { Position = 4, Latitude = 35.195739f, Longitude = -95.348899f},
            new Coordinate { Position = 5, Latitude = 31.895839f, Longitude = -97.789573f},
            new Coordinate { Position = 6, Latitude = 32.895839f, Longitude = -101.789573f},
            new Coordinate { Position = 7, Latitude = 34.115839f, Longitude = -100.225732f},
            new Coordinate { Position = 8, Latitude = 32.335839f, Longitude = -99.992232f},
            new Coordinate { Position = 9, Latitude = 33.535339f, Longitude = -94.792232f},
            new Coordinate { Position = 9, Latitude = 32.234235f, Longitude = -100.222222f}
        };
    }
}
