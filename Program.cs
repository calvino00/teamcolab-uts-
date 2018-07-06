using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamcolab
{
    class Program
    {
        public static int hasil(int x, int n)
        {
            
            int i = 0;
            if (x > 0)
            {
                for (int check = x; check <= n; check = check + x)
                  
                {
                    i = i + check;
                    //Console.WriteLine(i);
                    
                }
            }
            else if (x < 0)
            {
                for (int check = x; check >= n; check = check + x)
                {
                    i = i + check;
                    //Console.WriteLine(i);
                }
            }
            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("case(3, 10): " + (hasil(3, 10) ));
            Console.WriteLine("case(1, 10): " + (hasil(1, 10) ));
            Console.WriteLine("case(0, 10): " + (hasil(0, 10)));
            Console.WriteLine("case(-1, 10): " + (hasil(-1, 10)));
            Console.WriteLine("case(-1, -10): " + (hasil(-1, -10)));
        }
    }
}
