using System;
using System.Collections.Generic;

namespace BreakfastClubMyVersion
{
    public class Menu
    {

        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Menu(string name,  string category, string description, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Category = category;
        }
        static public List<Menu> MenuItems()
        {
            string item1Detail = "Eggs and Cheese Ommelette";
            Menu item1 = new Menu("Awesome Avocado", "Omellet", item1Detail, 15.10);

            string item2Detail = "Eggs and Cheese Ommelette";
            Menu Item2 = new Menu("Veggie Delight  ", "Omellet", item2Detail, 10.30);

            string item3Detail = "Eggs and Cheese Ommelette";
            Menu Item3 = new Menu("LEAN & GREEN", "Omellet", item3Detail, 13.00);

            string item4Detail = "Eggs and Cheese Ommelette";
            Menu Item4 = new Menu("CHICKEN FAJITA ", "Fajita", item4Detail, 10.00);

            string item5Detail = "Eggs and Cheese Ommelette";
            Menu Item5 = new Menu("Jump Start  Sanwish ", "Sandwhich", item5Detail, 13.50);

            string item6Detail = "Eggs and Cheese Ommelette";
            Menu Item6 = new Menu("The healthier English", "Combo", item6Detail, 12.50);

            string item7Detail = "Eggs and Cheese Ommelette";
            Menu Item7 = new Menu("The happy American", "Snadwhich", item7Detail, 14.50);

            string item8Detail = "Eggs and Cheese Ommelette";
            Menu Item8 = new Menu("Buttermilk Pancakes", " Pancakes", item8Detail, 11.50);

            string item9Detail = "Eggs and Cheese Ommelette";
            Menu Item9 = new Menu("Parfait", "Yogurt", item9Detail, 5.50);

            string item10Detail = "Eggs and Cheese Ommelette";
            Menu Item10 = new Menu("Tea", "Hot Tea", item10Detail, 1.00);

            string item11Detail = "Eggs and Cheese Ommelette";
            Menu Item11 = new Menu("Orange Juice", "Cold Orange Juice", item11Detail, 2.00);

            string item12Detail = "Eggs and Cheese Ommelette";
            Menu Item12 = new Menu("Coffee", "Dark Roasted Coffee", item12Detail, 1.25);
       



            List<Menu> menu = new List<Menu>();

            menu.Add(item1);
            menu.Add(Item2);
            menu.Add(Item3);
            menu.Add(Item4);
            menu.Add(Item5);
            menu.Add(Item6);
            menu.Add(Item7);
            menu.Add(Item8);
            menu.Add(Item9);
            menu.Add(Item10);
            menu.Add(Item11);
            menu.Add(Item12);

            return menu;


        }
        public override string ToString()
        {

            return "Iem" + ":" + Name +
                Description +
                Category +
                Price;
        }

    }
}
