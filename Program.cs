using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] atlagok = {3, 4, 3, 1, 5, 4, 3, 1, 5, 2, 4, 5};

            double atlag = 0;
            int db = 0;
            for(int i = 0; i < atlagok.Length; i++)
            {
                atlag += atlagok[i];
                db++;
            }
            
            Console.WriteLine($"átlag: {Math.Round(atlag = atlag / db, 1)}");




            Console.ReadKey();
        }

        
    }
}
