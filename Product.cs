    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra2.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Image ProductImage { get; set; } // Ảnh sản phẩm

        public Product(string name, decimal price, int quantity, Image productImage)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            ProductImage = productImage;
        }
    }
}
