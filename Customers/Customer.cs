using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvinienceStoreModel.Products;

namespace ConvinienceStoreModel.Customers
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public Customer()
        {

        }

        public void BuyProduct(Tuple<List<Product>, List<int>> productAndQuantity, decimal cash )
        {
            int count = productAndQuantity.Item1.Count;
            decimal price = 0m;
            for (int i = 0; i < count; i++)
            {
                price += (productAndQuantity.Item1[i].Price * productAndQuantity.Item2[i]);
            }
            if( cash >= price)
            {
                Console.WriteLine($"You can pay for the products and the cost is {price}");
            }
            else
            {
                Console.WriteLine($"You will need {Math.Abs(price - cash)} to buy the products");
            }
        }
    }
}
