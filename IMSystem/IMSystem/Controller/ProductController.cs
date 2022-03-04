using IMSystem.Container;
using IMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSystem.Controller
{
    public class ProductController
    {
        public ProductContainer productContainer;

        public ProductController()
        {
            productContainer = new ProductContainer();
        }
        public void AddProduct(int id, string name, string description)
        {
            productContainer.AddProduct(id, name, description);
        }
        public void RemoveProduct(int id)
        {
            productContainer.RemoveProduct(id);
        }
        public void FindProduct(int id)
        {
            productContainer.FindProduct(id);
        }
        public void PrintProducts()
        {
            productContainer.PrintAllProducts();
        }
    }
}
