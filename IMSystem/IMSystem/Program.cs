using IMSystem.Container;
using IMSystem.Model;

public class Program
{
    public static void Main(String[] args)
    {
        Product product1 = new Product(1, "Book", "Readable object");
        Product product2 = new Product(2, "Comic", "Fun readable object");
        Product product3 = new Product(3, "Newspaper", "Fake Information");
        ProductContainer container = new ProductContainer();

        // adding the products to the container and printing all values.
        container.AddProduct(product1);
        container.AddProduct(product2);
        container.AddProduct(product3);
        container.PrintAllProducts();

        // finding an object in the container and finding it again after removing it.
        container.FindProduct(2);
        container.RemoveProduct(product2);
        container.FindProduct(2);

    }
}
