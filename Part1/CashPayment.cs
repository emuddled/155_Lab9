using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class CashPayment : Payment
    {
        public CashPayment()
        {

        }
        public CashPayment(double a)
        {
            SetAmmount(a);
        }

        public void PaymentDetails()
        {
            Console.WriteLine("The payment was made in cash in the ammount of " + Math.Round(GetAmmount(), 2));
        }
    }
}
