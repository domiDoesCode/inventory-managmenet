using IMSystem.Container;
using IMSystem.Model;
using IMSystem.Controller;
using IMSystem.TUI;
using static System.Console;

public class Program
{
    private static ProductMenu productMenu;
    private static ProductController productController;

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

        productController = new ProductController();
        string prompt = "Welcome to the Product Management Menu. What would you like to do?";
        string[] options = { "Create Product", "Delete Product", "Find Product", "Print all products", "Exit" };
        productMenu = new ProductMenu(prompt, options);

        Run();
    }
    private static void Run() {

        string prompt = "Welcome to the Inventory Management System. What would you like to do?";
        string[] options = { "Product Menu", "About", "Exit" };
        MainMenu MM = new MainMenu(prompt, options);
        int selectedIndex = MM.Run();

        switch (selectedIndex)
        {
            case 0:
                RunProductMenu();
                break;
            case 1:
                DisplayAboutInfo();
                break;
            case 2:
                ExitProgram();
                break;
        }
    }
    private static void RunProductMenu()
    {
        string prompt = "Welcome to the Product Management Menu. What would you like to do?";
        string[] options = { "Create Product", "Delete Product", "Find Product", "Print all products", "Exit" };
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
                PrintAllProducts();
                break;
            case 4:
                ExitProgram();
                break;
        }
    }
    private static void DisplayAboutInfo()
    {
        
        Clear();
        WriteLine("A simple inentory management system with a text user interface.");
    }
    private static void ExitProgram()
    {
        Environment.Exit(0);
    }

    private static void CreateProduct()
    {
        Clear();
        int id;
        string name, description;
        WriteLine("You are about to create a new product!");
        WriteLine("Please input the id of the product: ");
        id = Convert.ToInt32(ReadLine());
        WriteLine("Please enter the name of the product: ");
        name = ReadLine();
        WriteLine("Please enter the description of the product: ");
        description = ReadLine();

        productController.AddProduct(id, name, description);
        WriteLine();
        WriteLine("Id is {0}.", id);
        WriteLine("Name is {0}.", name);
        WriteLine("Description is {0}.", description);

        WriteLine("Press any key to return to the product menu...");
        ReadKey(true);
        BackToProductMenu();
        

    }
    private static void DeleteProduct()
    {
        Clear();
        int id;
        WriteLine("Please input the id of the product that you want to delete from the system.");
        id = Convert.ToInt32(ReadLine());

        productController.RemoveProduct(id);

        WriteLine("Press any key to return to the product menu...");
        ReadKey(true);
        BackToProductMenu();
    }
    private static void FindProduct()
    {
        Clear();
        int id;
        WriteLine("Please input the id of the product that you are trying to find: ");
        id = Convert.ToInt32(ReadLine());

        WriteLine();
        productController.FindProduct(id);

        WriteLine("Press any key to return to the product menu...");
        ReadKey(true);
        BackToProductMenu();
    }
    private static void PrintAllProducts()
    {
        
        Clear();
        WriteLine("LIST OF ALL PRODUCTS: ");
        WriteLine();
        productController.PrintProducts();

        WriteLine("Press any key to return to the product menu...");
        ReadKey(true);
        BackToProductMenu();

    }
    private static void BackToProductMenu()
    {
        int selectedIndex = productMenu.Run();

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
                PrintAllProducts();
                break;
            case 4:
                ExitProgram();
                break;
        }
    }
}
