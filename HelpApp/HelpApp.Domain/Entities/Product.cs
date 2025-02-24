using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Domain.Entities
{
    class Product
    {
        #region Atributos
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int CateegoryId { get; set; }
        #endregion


        #region Construtores
        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;

        }
         public Category Category { get; set; }
        #endregion
    }
}
