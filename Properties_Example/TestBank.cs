using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Example
{
    class TestBank
    {
       static void Main(string[] args)
        {
            Customers obj = new Customers(101, "Samantha","Hyderabad", true, 5000.50, Cities.Kochi);


            

            // write only properties
            //obj.set_Cust_Id(1001); // set property
            /*
            if(obj.Status == true)
            {
                Console.WriteLine("Custmer status account :active");
            }
            else
            {
                Console.WriteLine("Custmer status account :in-active");
            }
            obj.CName = "Samantha Akeneni";
            Console.WriteLine("Custmer Name :" +obj.CName);

            obj.Balance -=3000;
            Console.WriteLine("Custmer Name :" + obj.Balance);

            obj.City = Cities.Hyderabad;
            Console.WriteLine("Custmer Name :" + obj.City);
            */




            //Console.WriteLine(obj.CId);//get property
            //Console.WriteLine(obj.CName);//get property for name
            //Console.WriteLine(obj.City);
            // Console.WriteLine(obj.Balance);
            //Console.WriteLine(obj.Status);



            Console.ReadLine();

            
      

        }
    }
}
