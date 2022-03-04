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
        public void AddProduct(Product product)
        {
            productContainer.AddProduct(product);
        }
        public void RemoveProduct(Product product)
        {
            productContainer.RemoveProduct(product);
        }
        public void FindProduct(int id)
        {
            productContainer.FindProduct(id);
        }
        public void PritnProducts()
        {
            productContainer.PrintAllProducts();
        }
    }
}
