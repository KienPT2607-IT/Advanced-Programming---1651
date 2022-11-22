using ProductManagement;

bool running = true;
Shop shoppe = new Shop();

while (running)
{
    shoppe.PrintMenu();
    int choice = shoppe.GetChoice();

    if (choice == 1) shoppe.AddNewProduct();
    else if (choice == 2) shoppe.SellProduct();
    else System.Console.WriteLine("System terminated");

    running = choice <= 0 || choice >= 3;
}