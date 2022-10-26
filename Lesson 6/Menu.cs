using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Menu
    {
        public static void Menu1()
        {
            
            string ans;
            Console.WriteLine("Choose on of the action:");
            Console.WriteLine("1.Add product");
            Console.WriteLine("2.Show all of the products");
            Console.WriteLine("3.Show product by type");

            ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    CreateInventory.AddNewProduct();
                    break;
                case "2":
                    Inventory.ShowAllProd();

                    break;
                case "3":
                    break;
            }
        }
    }
}
