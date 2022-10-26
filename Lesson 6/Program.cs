using Lesson_6;
string cont  = "+";
string ans;

while (cont == "+")
{
    Console.WriteLine("Choose on of the action:");
    Console.WriteLine("1.Add product");
    Console.WriteLine("2.Show all of the products");
    Console.WriteLine("3.Show product by type");

    ans = Console.ReadLine();

    switch (ans)
    {
        case "1":
            CreateInventory.AddNewProduct();
            cont = Continue();
           
            break;
        case "2":
            Inventory.ShowAllProd();
            cont = Continue();
            break;
        case "3":
            break;
    }
}

string Continue()
{
    string cont;
    Console.WriteLine("Do you want to continue?(+/-)");
    cont = Console.ReadLine();
    return cont;
}