using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSystem.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product(int _id)
        {
            this.Id = _id;
        }

        public Product(int _id, string _name, string _description)
        {
            this.Id = _id;
            this.Name = _name;
            this.Description = _description;
        }
    }
}
