using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_6
{
    public class CreateInventory : Inventory
    {
        Inventory inventory = new Inventory();

    
        public static void AddNewProduct()
        {
            string name;
            int price;
            int quantity;
            string ans;

            Console.WriteLine("Choose type of product");
            Console.WriteLine("1.Food.");
            Console.WriteLine("2.Machinary");
            Console.WriteLine("3.Chemicals");

            ans = Console.ReadLine();

            switch (ans)
            {
                case "1":   
                    name = Input.InputName();    
                    price = Input.InputPrice(name);
                    quantity = Input.InputQuantity(name);

                    Product food = new Food (name, price, quantity);
                    Inventory.AddFood(food);
                    break;

                case "2":
                    name = Input.InputName();
                    price = Input.InputPrice(name);
                    quantity = Input.InputQuantity(name);

                    Product machinary = new Machinary(name, price, quantity);
                    Inventory.AddMachinary(machinary);
                    break;

                case "3":
                    name = Input.InputName();
                    price = Input.InputPrice(name);
                    quantity = Input.InputQuantity(name);

                    Product chemicals = new Chemicals(name, price, quantity);
                    Inventory.AddChemicals(chemicals);
                    break;
            }

        }


    }
    public static class Input
    {
        public static string InputName()
        {
            Console.WriteLine("Enter name of product");
            string name = Console.ReadLine();
            return name;
        }

        public static int InputPrice(string name)
        {
            Console.WriteLine($"Enter price of the {name}");
            int price = Convert.ToInt32(Console.ReadLine());
            return price;   
        }
        public static int InputQuantity(string name)
        {
            Console.WriteLine($"Enter quantity of the {name}");
            int quantity = Convert.ToInt32(Console.ReadLine());
            return quantity;
        }
    }

}
