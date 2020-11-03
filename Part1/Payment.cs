using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Payment
    {
        private double ammount;

        public Payment()
        {
        }

        public Payment(double a)
        {
            SetAmmount(a);
        }

        public void SetAmmount(double a)
        {
            ammount = a;
        }

        public double GetAmmount()
        {
            return ammount;
        }

        public void PaymentDetails()
        {
            Console.WriteLine("The payment was made in the ammount of " + Math.Round(GetAmmount(), 2));
        }
    }
}
