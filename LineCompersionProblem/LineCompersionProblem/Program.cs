using System;
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
            LineCompersion line = new LineCompersion(1,2,3,4);
            line.Length();
            Console.ReadLine();
        }
    }
}
