using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Inventory
    {
        public static List<Product> Machinary = new List<Product>();
        public static List<Product> Chemicals = new List<Product>();
        public static List<Product> Food = new List<Product>();


        public static void AddFood(Product food)
        {
             Food.Add(food);
            

        }
        public static void AddChemicals(Product chemicals)
        {
            Chemicals.Add(chemicals);
            

        }

        public static void AddMachinary(Product machinary)
        {
            Machinary.Add(machinary);

        }

        public static void ShowAllProd()
        {
            Console.WriteLine("This is  all product");

            for (int x = 0; x < Machinary.Count; x++)
            {
                Console.WriteLine(Machinary[x].name);
            }
            for (int z = 0; z < Food.Count; z++)
            {
                Console.WriteLine(Food[z].name);
            }
            for (int y = 0; y < Chemicals.Count; y++)
            {
                Console.WriteLine(Chemicals[y].name);
            }

        }
    }
}
