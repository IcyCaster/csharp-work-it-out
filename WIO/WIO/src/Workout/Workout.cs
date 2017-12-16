using System;
using System.Collections.Generic;
using UnitsNet.Units;

namespace WIO
{
    public class Workout
    {
        public DateTime Date { get; set; }
        public Weight Weight { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}