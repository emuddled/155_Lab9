using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class CardPayment : Payment
    {
        private long cardNumber;
        private string cardholderName;

        public CardPayment()
        {

        }

        public CardPayment(double a, long c, string n)
        {
            SetAmmount(a);
            SetCardNumber(c);
            SetCardholderName(n);

        }

        public void SetCardNumber(long c)
        {
            cardNumber = c;
        }

        public void SetCardholderName(string n)
        {
            cardholderName = n;
        }

        public string GetCardholderName()
        {
            return cardholderName;
        }

        public long GetCardNumber()
        {
            return cardNumber;
        }



        public void PaymentDetails()
        {
            Console.WriteLine("The payment was made by a card in the ammount of " + Math.Round(GetAmmount(), 2));
            Console.WriteLine("The cardholder name is " + cardholderName);
            Console.WriteLine("The card number is " + cardNumber);
        }
    }
}
