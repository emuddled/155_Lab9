/// Lab No. 9		Exercise Part 1
/// File Name: Payments
/// @author: Evan Sinclair
/// Date:  Nov 2, 2020
///
/// Problem Statement: Define a class named Payment that contains an instance variable of type double that stores the 
/// amount of the payment and appropriate getter and setter methods.  Also create a method names PaymentDetails that 
/// outputs an English sentence to describe the amount of the payment.
/// 
/// Next, define a named CashPayment that is derived from Payment.  This class should redefine the PaymentDetails method 
/// to indicate that the payment is in cash.  Include appropriate constructor(s).
/// 
/// Define a class named CreditCardPayment that is derived from Payment.  This class should contain instance variables 
/// for the name on the card, and credit card number.  Include appropriate constructor(s). Finally, redefine the Payment 
/// Details method to include all credit card information in the printout.

/// Create a Main method that creates at least two CashPayment and two CreditCardPayment objects with different values 
/// and calls PaymentDetails for each.
/// 
/// 
/// Overall Plan:
/// 1)Create Payment class and implement paymentdetails method
/// 2)Create Cashpayment and cardPayment making sure to override PaymentDetails
/// 3)Create driver to test out PaymentDetails on diffrent classes
///
///

using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment pay1 = new Payment(3.70);
            Payment pay2 = new Payment(43.70);
            CardPayment pay3 = new CardPayment(40.21, 1299933049, "John Doe");
            CardPayment pay4 = new CardPayment(700.27, 1008744528, "Jane Doe");
            CashPayment pay5 = new CashPayment(5.99);
            CashPayment pay6 = new CashPayment(2.90);

            pay1.PaymentDetails();
            pay2.PaymentDetails();
            pay3.PaymentDetails();
            pay4.PaymentDetails();
            pay5.PaymentDetails();
            pay6.PaymentDetails();
        }
    }
}
