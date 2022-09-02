using Register;

Product p1 = new Product("milk", 3.50m);
Product p2 = new Product("eggs", 1.00m);
Product p3 = new Product("bread", 3.00m);
Product p4 = new Product("coffee", 4.50m);
List<Product> products = new List<Product>();
products.Add(p1); products.Add(p2); products.Add(p3); products.Add(p4);


Console.WriteLine("Welcome! Please choose an item to add to you cart.");
for (int i = 1; i <= products.Count; i++)
{
    foreach (Product product in products)
    {
        Console.WriteLine($"{i++}. {product}");
    }
}
List<Product> cart = new List<Product>();



bool KeepGoing = false;

while (!KeepGoing)
{
    Console.Write("Please enter product #: ");
  
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            cart.Add(p1);
            break;
        case 2:
            cart.Add(p2);
            break;
        case 3:
            cart.Add(p3);
            break;
        case 4:
            cart.Add(p4);
            break;
        default:
            Console.WriteLine("Sorry, invalid entry!");
            break;
    }
    Console.Write("Add another item? y/n: ");
    string yesno = Console.ReadLine().ToLower();
    if (yesno == "y" || yesno == "yes")
    {
        KeepGoing = false;
    }
    else if (yesno == "n" || yesno == "no")
    {
        //decimal subtotal = CashRegister.GrandTotal(cart);
        //decimal taxtotal = CashRegister.CalulateTax(cart);
        //decimal finaltotal = subtotal + taxtotal;
        //string converted = finaltotal.ToString("0.00");

        Console.WriteLine($"Thank you! Your total is: ${CashRegister.FinalTotal(cart)}.");
        KeepGoing = true;
    }
    else
    {
        Console.WriteLine("Invalid entry!");
    }

    
}