using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classActivity
{
    
    
    internal class ClassResults
    {
        private string engName;
        private string LtnName;
        private double date;

        public ClassResults (string engName, string ltnName, double date)
        {
            this.engName = engName;
            LtnName = ltnName;
            this.date = date;
        }

        public string EngName { get => engName; set => engName = value; }
        public string LtnName1 { get => LtnName; set => LtnName = value; }
        public double Date { get => date; set => date = value; }
    
        
        public void brids ()
        {
            Console.WriteLine( "Enter english name of bird");
            engName = Console.ReadLine();

            Console.WriteLine("Enter Latin name of bird");
            LtnName= Console.ReadLine();

            Console.WriteLine("Enter the data of its last sighting");
            date = Convert.ToDouble(Console.ReadLine());

            ClassResults bd = new ClassResults(engName,LtnName, date);  
            Console.WriteLine( " A summary of the bird" + "\n The name of the bird is" + engName +
                " Its Latin namee is " + "The last date it was sighted was on the " + date);
        }

       
    }

}
