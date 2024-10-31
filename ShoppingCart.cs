using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kiemtra2.Models;
namespace kiemtra2
{
    public class ShoppingCart
    {
        public List<Product> CartItems { get; private set; }

        public ShoppingCart()
        {
            CartItems = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            var existingProduct = CartItems.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                CartItems.Add(product);
            }
        }

        public void RemoveFromCart(Product product)
        {
            CartItems.Remove(product);
        }

        public decimal GetTotalPrice()
        {
            return CartItems.Sum(p => p.Price * p.Quantity);
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}

