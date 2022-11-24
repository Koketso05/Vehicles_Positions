using ListConsoleApp;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Dynamic;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;
using ListConsoleApp.Data;
using ListConsoleApp.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.Collections;
using System.Reflection;

var coordinates = CoordinateCollection.CoordinateList;

TraceVehiclesByLocation(coordinates);


void TraceVehiclesByLocation(List<Coordinate> coordinates)
{
   string filePath = @"..\..\..\Data\VehiclePositions.dat";
    var file_lines = new ArrayList();

    // intialize stopwatch
    var file_reader_watch = new Stopwatch();
    file_reader_watch.Start();

    // read all file lines
    string[] f_lines = File.ReadAllLines(filePath);
    file_reader_watch.Stop();
    Console.WriteLine($"Data file read execution time: {file_reader_watch.ElapsedMilliseconds} ms");

    var close_position_calculate_watch = new Stopwatch();
    close_position_calculate_watch.Start();
    file_lines.AddRange(f_lines);
    foreach (var coordinate in coordinates)
    {
        var lat = coordinate.Latitude.ToString().Substring(0, 4);
        var lng = coordinate.Longitude.ToString().Substring(0, 4);

        foreach (string line in file_lines)
        {
            if (line.Contains(lat) && line.Contains(lng))
            {
                // TODO: You can increment a count to track number of items found
                Console.WriteLine("Vehicle identified");
            }
        }
    }    
    Console.WriteLine($"Closest position calculation execution time: {close_position_calculate_watch.ElapsedMilliseconds} ms");
    close_position_calculate_watch.Stop();

    // Display total time it took
    Console.WriteLine($"Total execution time: {close_position_calculate_watch.ElapsedMilliseconds + file_reader_watch.ElapsedMilliseconds} ms");    

}



