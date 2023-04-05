﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompersionProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LineCompersion line = new LineCompersion(1, 2, 3, 4);
            double length1 = line.Length();
            Console.WriteLine("Length of 1st Line : " + length1);

            LineCompersion line2 = new LineCompersion(5, 6, 7, 9);
            double length2 = line2.Length();
            Console.WriteLine("Length of 2nd Line : " + length2);

            if (length1.Equals(length2))
            {
                Console.WriteLine("Both Line Are Equal");
            }
            else
            {
                Console.WriteLine("Both Line Are not Equal");
            }
        }
    }
}
