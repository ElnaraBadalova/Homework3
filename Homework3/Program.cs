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
            Hw1 Homework1 = new Hw1();
            //int[] mass1 = {7, 1, 9, 12};
            //Homework1.GetMinMax(mass1,out int a, out int b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            double avg = Homework1.AverageNumbers(7,9,1, -4,5);
            Console.WriteLine(avg);

            

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

        public double AverageNumbers(params double[] mass)
        {
            double sum = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                sum = sum + mass[i];
            }
            if (mass.Length > 0)
                return sum / mass.Length;
            else
                return 0;
        }

    }
}    
       
    

