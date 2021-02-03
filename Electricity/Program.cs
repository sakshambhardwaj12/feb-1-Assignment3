using System;

namespace Electricity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Customer Id");
            string custid=Console.ReadLine();
            Console.WriteLine("Enter Customer name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter units consumed");
            int amount = int.Parse(Console.ReadLine());

            Bill b = new Bill(custid,name,amount);
            b.billcalculation();

        }
    }
}
