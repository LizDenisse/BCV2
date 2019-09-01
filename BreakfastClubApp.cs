using System;
using System.Collections.Generic;
using System.Linq;


namespace BreakfastClubMyVersion
{
    public class BreakfastClubApp
    {

        List<Menu> menus = Menu.MenuItems();
        Order order = new Order();
        int input = 0;
        string inp = "";
        int cuantity = 0;
        double amount = 0;
        public void RunApp()
        {
            Console.WriteLine("Welcome to the Breakfast Club ");

            bool orderMore = true;
            while (orderMore)
            {
                Console.WriteLine("\n Select a Number from the Menu ");
                Console.WriteLine("_______________________________");
                              
                order.PrintMenu();
                inp = Console.ReadLine();
                input = int.Parse(inp);


                Console.WriteLine(menus[input].Name+" "+ menus[input].Description);
                Console.WriteLine("do you want to buy this item? ");

                string b = Console.ReadLine().ToLower().Trim();

                if (b=="y")
                {
                    if (input > 0 && input < menus.Count)
                    {
                        order.AddMenuItem(input, cuantity);
                        order.PrintCart();
                    }

                    if (input == menus.Count + 1)
                    {
                        order.PrintCart();

                        Console.WriteLine("do you want to pay with 1-Card, 2- Check or 3- Cash");
                        string s = Console.ReadLine();
                        int paySelection = int.Parse(s); 

                        if (paySelection== 1)
                        {
                            Payment.CreditCardPayment();
                        }

                      else  if   (paySelection ==2)
                       {
                            Payment.CheckPayment();

                        }

                      else if (paySelection == 3)

                        {
                            Payment.CashPayment(amount);
                        }

                        else
                        {
                            Console.WriteLine("Invalid entry please select 1-Card, 2- Check or 3- Cash ");
                             s = Console.ReadLine();
                             paySelection = int.Parse(s);

                        }
                        break;
                    }
                }



        
            }


        }
      
    }

}

