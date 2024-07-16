using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // BirdData data = new BirdData();
            //data.brids();
            
            Console.WriteLine("Please enter your final mark");
            Double mark;//= Convert.ToDouble(Console.ReadLine());
            while (Double.TryParse(Console.ReadLine(), out mark) == false)
            {

                Console.WriteLine("please enter your mark >>>> ");

            }
            if (mark <= 45)
            {
                Console.WriteLine("failed Sorry please try again");
            }
            else if (mark == 49)
            {
                Console.WriteLine("result is passed (condoned);");

            }
            else if (mark == 74)
            {
                Console.WriteLine("the result is passed");
            }
            else
            {
                Console.WriteLine("Distinction");
            }

            

            Console.ReadKey();
        }

    }
         
}
