using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    class TestCustomersClass
    {


        static void Main(string[] args)
        {
            Customers obj = new Customers(101, "Samantha", "Hyderabad", true, 5000.50, Cities.Kochi);

            obj[0] = 1001;
            obj[1] = "Samantha Akineni";
            obj[2] = "Hyderabad";
            obj[3] = false;
            obj[4] = 5000000;
            obj[5] = Cities.Hyderabad;

            Console.WriteLine(obj[0]); 
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj[3]);
            Console.WriteLine(obj[4]);
            Console.WriteLine(obj[5]);



        }
    }
}
