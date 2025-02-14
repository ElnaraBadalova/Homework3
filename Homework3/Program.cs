using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Hw1 MinMax = new Hw1();
            int[] mass1 = {7, 1, 9, 12};

            MinMax.GetMinMax(mass1,out int a, out int b);
            Console.WriteLine(a);
            Console.WriteLine(b);

        }

    }
    internal class Hw1
    {
        public void GetMinMax(int[] mass, out int min, out int max)
        {
            min = mass[0];
            max = mass[0];

            for (int i=1; i < mass.Length; i++)
            {
                if (mass[i] < min)
                    min = mass[i];
                
            
                if (mass[i] > max)
                    max = mass[i];
            }

        }
    }
}    
       
    

