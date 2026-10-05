
double allTotal = 0;
int choice = 1;
int itemCount = 0;



while (choice == 1)
{
    itemCount = itemCount + 1;
    Console.Write("Enter Product Name: ");
    string productName = Console.ReadLine();
    Console.Write("Enter Price:  ");

       double price = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter Qty: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
    double total = price * quantity;
    Console.WriteLine("Total = " + total);
    allTotal = allTotal + total;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Add Another Item? 1 = Yes, and 0 = No:");
    Console.ResetColor();
    choice = Convert.ToInt32(Console.ReadLine());

    
}

Console.WriteLine("All Total = " + allTotal);

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Items Entered = " + itemCount);
Console.WriteLine("All Total = " + allTotal);

Console.ResetColor();

if (allTotal > 100)
{
    
        double discount = allTotal * 0.10;
        double finalTotal = allTotal - discount;

        Console.WriteLine("Discount = " + discount);
        Console.WriteLine("Final Total = " + finalTotal);
    
}





