using Pathlock_RefrigeratorApp.Entity;

Refrigerator refrigerator = new Refrigerator();

while (true)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("Select an action:");
    Console.WriteLine("1. Insert product");
    Console.WriteLine("2. Consume product");
    Console.WriteLine("3. Show current status");
    Console.WriteLine("4. Check expired products");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter quantity: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("Enter expiry date (yyyy-MM-dd): ");
            DateTime expiryDate = DateTime.Parse(Console.ReadLine());

            refrigerator.InsertProduct(productName, quantity, expiryDate);
            break;

        case 2:
            Console.Write("Enter product name: ");
            string consumedProductName = Console.ReadLine();
            Console.Write("Enter consumed quantity: ");
            double consumedQuantity = double.Parse(Console.ReadLine());

            refrigerator.ConsumeProduct(consumedProductName, consumedQuantity);
            break;

        case 3:
            refrigerator.ShowCurrentStatus();
            break;

        case 4:
            refrigerator.CheckExpiredProducts();
            break;

        case 0:
            Console.WriteLine("Exiting...");
            return;

        default:
            Console.WriteLine("Invalid choice.");
            continue;
    }
}