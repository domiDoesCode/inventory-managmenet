using IMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSystem.Container
{
    public class ProductContainer
    {
        public List<Product> products;


        public ProductContainer()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (products.Contains(product))
            {

                Console.WriteLine("The product already exists in the system.");
            }
            else
            {
                products.Add(product);
                Console.WriteLine("The product " + product.Name + " has been added to the system.");
            }
        }
        public void RemoveProduct(Product product)
        {
            if (products.Contains(product))
            {
                products.Remove(product);
                Console.WriteLine("The product " + product.Name + " has been removed.");
            } 
            else
            {
                Console.WriteLine("There was an error in removing the product becaz");
            }
        }
        public void FindProduct(int id)
        {
            bool found = products.Any(x => x.Id == id);
            if(found)
            {
                Console.WriteLine("The product has been found in the system.");
            } 
            else 
            { 
                Console.WriteLine("There was an issue finding the product in the system."); 
            }
            
        }
        public void PrintAllProducts()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p.Name + " with the ID: " + p.Id + ".");
            }
        }
    }
}
