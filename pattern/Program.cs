using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 6;
            for(int i=n; i>=1;i--)
            {
                for(int j=i;j>=1;j--)
                {
                    if (j == 1)
                        Console.Write(" 1");
                    else if (j == i)
                        Console.Write(" " + n);
                    else
                        Console.Write(" " + j);
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
