using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CloserTo10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(Closer(13, 15));    // output : 13
            //Console.WriteLine(Closer(13, 13));   // output : 0
            //Console.WriteLine(Closer(3, 5));      // output : 5
            //Console.WriteLine(Closer(13, 7));    // output : 0
            //Console.WriteLine(Closer(-3, -5));   // output : -3
            //Console.WriteLine(Closer(-3, -1));   // output : -1
            //Console.ReadLine();
        }
        public int Closer(int a, int b)
        {
            int calcA = a - 10;
            int calcB = b - 10;
            if (Math.Abs(calcA) == Math.Abs(calcB))
            {
                return 0;
            }
            else if ((a >= 10 || b >= 10) && a < b)
            {
                return a;
            }
            else if ((a >= 10 || b >= 10) && b < a)
            {
                return b;
            }
            else if (calcB > calcA && Math.Abs(a) != Math.Abs(b))
            {
                return b;
            }
            else if ((calcA < 0 || calcB < 0) && (calcA > calcB && Math.Abs(a) != Math.Abs(b)))
            {
                return a;
            }
            else return Closer(a, b);
        }

        public int Closer_LylesMug(int a, int b)
        {
            long distanceA = Math.Abs(10 - (long)a);
            long distanceB = Math.Abs(10 - (long)b);
            
            if (distanceA == distanceB)
            {
                return 0;
            }

            return distanceA > distanceB ? b : a;
        }

        ///user2023861
        ///

        public int user2023861_Closer(int a, int b)
        {
            double avg = ((double)a + (double)b) / 2.0;
            return ( a == b || avg == 10.0) ? 0 :
                   avg > 10.0 ? Math.Min(a, b) : Math.Max(a, b);
        }

    }
}
