using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClubMyVersion
{
    public class Payment
    {
    

        
        
        public static void CreditCardPayment(/*string crnumber,string date,string cvv*/)
        {
            bool con = true;

            while (true)
            {

                Console.WriteLine("Please enter your credit card number: ");
                string crnumber = Console.ReadLine();
                char[] credit = crnumber.ToCharArray();
                foreach (char c in credit)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("You did not enter a number.Please try again");
                        con = false;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (crnumber.Length != 16)
                {
                    Console.WriteLine("You did not enter a credit card number");

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{ credit}");
                    continue;
                }

                break;
            }
            while (con)
            {
                Console.WriteLine("Please enter the expiration date (enter two digits for month and four for year): ");
                string date = Console.ReadLine();
                char[] data = date.ToCharArray();
                foreach (char c in data)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("You did not enter a number.Please try again");
                        con = false;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (date.Length != 6)
                {
                    Console.WriteLine("You did not enter a date.Please try again");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{ data}");
                    continue;
                }
                break;
            }
            while (con)
            {
                Console.WriteLine("Please enter the number on the back of your card(cvv): ");
                string cvv = Console.ReadLine();
                char[] backofcard = cvv.ToCharArray();
                foreach (char c in backofcard)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("You did not enter a number.Please try again");
                        con = false;
                    }
                    else
                    {
                        continue;
                    }

                }
                if (cvv.Length != 3)
                {
                    Console.WriteLine("You did not enter a date.Please try again");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{backofcard}");
                    Console.WriteLine();
                    continue;
                }
                break;
            }

        }
        public static void CheckPayment()
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter your check card number: ");
                string cknumber = Console.ReadLine();
                char[] checkno = cknumber.ToCharArray();
                foreach (char c in checkno)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("You did not enter a number.Please try again");
                        con = false;
                    }
                    else
                    {
                        Console.WriteLine("Thank you");
                        continue;
                    }
                }
                break;
            }
        }
        public static void CashPayment(double amount)
        {
            Console.WriteLine("How much cash do you want to insert: ");
            amount = double.Parse(Console.ReadLine());

            Order c = new Order();
            double total = c.GetTotal();

            if (total < amount)
            {
                double a = amount - total;
                Console.WriteLine(Math.Round(a, 2));
            }
            else
            {
                Console.WriteLine("You don`t have enough money");

            }
        }
        public static void Taxes(double amount)
        {
            double tax = amount * (6 / 100);
            Console.WriteLine(tax);

        }

    }

}