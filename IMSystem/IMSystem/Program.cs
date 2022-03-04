using IMSystem.Container;
using IMSystem.Model;
using IMSystem.Controller;
using IMSystem.TUI;
using static System.Console;

public class Program
{
    public static void Main(String[] args)
    {
        //Product product1 = new Product(1, "Book", "Readable object");
        //Product product2 = new Product(2, "Comic", "Fun readable object");
        //Product product3 = new Product(3, "Newspaper", "Fake Information");
        //ProductContainer container = new ProductContainer();

        //// adding the products to the container and printing all values.
        //container.AddProduct(product1);
        //container.AddProduct(product2);
        //container.AddProduct(product3);
        //container.PrintAllProducts();

        //// finding an object in the container and finding it again after removing it.
        //container.FindProduct(2);
        //container.RemoveProduct(product2);
        //container.FindProduct(2);

        //Console.WriteLine("**********************************************************");

        ////Controller test functions
        //ProductController controller = new ProductController();
        //controller.AddProduct(product1);
        //controller.AddProduct(product2);

        //controller.FindProduct(2);
        //controller.RemoveProduct(product2);
        //controller.FindProduct(2);

        string prompt = "Welcome to the Inventory Management System. What would you like to do?";
        string[] options = { "Product Menu", "About", "Exit" };
        MainMenu MM = new MainMenu(prompt, options);
        int selectedIndex = MM.Run();

        switch (selectedIndex)
        {
            case 0:
                RunFirstChoice();
                break;
            case 1:
                DisplayAboutInfo();
                break;
            case 2:
                ExitProgram();
                break;
        }


        WriteLine("Press any key to exit...");
        ReadKey(true);

    }
    private static void RunFirstChoice()
    {
        string prompt = "Welcome to the Product Management Menu. What would you like to do?";
        string[] options = { "Create Product", "Delete Product", "Find Product", "Exit" };
        ProductMenu PM = new ProductMenu(prompt, options);
        int selectedIndex = PM.Run();

        switch (selectedIndex)
        {
            case 0:
                CreateProduct();
                break;
            case 1:
                DeleteProduct();
                break;
            case 2:
                FindProduct();
                break;
            case 3:
                ExitProgram();
                break;
        }
    }
    private static void DisplayAboutInfo()
    {
        Clear();
        WriteLine("A simple inentory management system with a text user interface.");
        WriteLine("Press any key to return to the main menu.");
        ReadKey(true);
        string prompt = "Welcome to the Inventory Management System. What would you like to do?";
        string[] options = { "Product Menu", "About", "Exit" };
        MainMenu MM = new MainMenu(prompt, options);
        MM.Run();
    }
    private static void ExitProgram()
    {
        WriteLine("Press any key to exit...");
        ReadKey(true);
        Environment.Exit(0);
    }

    private static void CreateProduct()
    {

    }
    private static void DeleteProduct()
    {

    }
    private static void FindProduct()
    {

    }
}
