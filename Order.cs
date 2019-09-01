using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClubMyVersion
{
    public class MenuItem
    {
        public string OrderName;
        public double OrderPrice;
        double total = 0;
    }
    public class Order
    {
        List<Menu> menus = Menu.MenuItems();
        List<MenuItem> cart = new List<MenuItem>();
        public Order()
        {
        }
        public List<MenuItem> AddMenuItem(int input, int cuantity)
        {
            for (int i = 0; i < cuantity; i++)
            {
                cart.Add(new MenuItem { OrderName = menus[input].Name, OrderPrice = menus[input].Price });
            }
           return cart;
        }
           //_______________________________________________________________________________________________________________
        public void PrintMenu()
        {
            int i = 0;
            
            foreach (var n in menus)
            {
                i++;
                Console.WriteLine(i+". "+"{0,1} {1,20} {2,15}" , n.Name  , n.Category, n.Price);
               // Console.WriteLine("Description: "+n.Description);
            }
            Console.WriteLine(menus.Count+1+". End Order and Procede to payment");
        }
        //________________________________________________________________________________________________________________
        

        public double GetTotal()
        {
            double total = cart.Sum(cart => cart.OrderPrice);

            return total;

        }
        public void PrintCart()
        {
           double total= GetTotal();
            Console.WriteLine("\n Cart Total: " + total.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("________________________________");
            int i = 0;
            foreach (var item in cart)
            {
                i++;
                Console.WriteLine(i + "." + item.OrderName + "\t" + item.OrderPrice);
            }
        }
    }






}

