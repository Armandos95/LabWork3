using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_Lab3
{
    class Predator
    {
        public Point coordinates;
        public int age;
        public int stepsWithoutFood;
        public static int genStart;
        public static int genPeriod;
        public static int starve;

        public Predator(int x, int y)
        {
            coordinates.X = x;
            coordinates.Y = y;
            age = 0;
            stepsWithoutFood = 0;
        }
    }
}
