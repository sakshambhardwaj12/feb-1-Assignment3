using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity
{
    public class Bill
    {
        private string custid;
        private string name;
        private int amount;
        public Bill(string custid,string name,int amount)
        {
            this.custid = custid;
            this.name = name;
            this.amount = amount;
        }

        public void billcalculation()
        {
            double charge, surcharge=0;
            Console.WriteLine("Customer IDNO :{0}", custid);
            Console.WriteLine("Customer Name :{0}", name);
            Console.WriteLine("unit Consumed :{0}", amount);
            if (amount<=199)
            {
                charge = 1.20 * amount;
                Console.WriteLine("Amount Charges @Rs 1.20 per unit : {0}",charge);
            }
            else if(amount>=200 && amount<400)
            {
                charge = 1.50 * amount;
                Console.WriteLine("Amount Charges @Rs 1.50 per unit : {0}", charge);
            }
            else if(amount>=400 && amount<=600)
            {
                charge = 1.80 * amount;
                surcharge = (0.15) * amount * 2;
                Console.WriteLine("Amount Charges @Rs 1.80 per unit : {0}", charge);
                Console.WriteLine("Surcharge Amount : {0}", surcharge);
            }
            else
            {
                charge = 2.00 * amount;
                surcharge = (0.15) * amount * 2;
                Console.WriteLine("Amount Charges @Rs 2.00 per unit : {0}", charge);
                Console.WriteLine("Surcharge Amount: {0}", surcharge);
            }
            if(surcharge !=0)
            {
                Console.WriteLine("Net Amount paid by the customer : {0}",charge+surcharge);
            }
            else
            {
                Console.WriteLine("Net Amount paid by customer :{0}",charge);
            }

            


        }
    }
}
