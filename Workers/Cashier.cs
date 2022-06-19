using ConvinienceStoreModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvinienceStoreModel.Workers
{
    public class Cashier : Staff
    {
        public Cashier(string firstName, string lastName, string address):base()
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            EmployeeID = LastName  +"." + FirstName[0] + LastName[0] ;
        }

        public void SellProduct(Tuple<List<Product>, List<int>> productAndQuantity, decimal cash)
        {
            int count = productAndQuantity.Item1.Count;
            decimal price = 0m;
            Console.WriteLine("Item Name\t QTY\t Cost") ;
            for (int i = 0; i < count; i++)
            {
                price += (productAndQuantity.Item1[i].Price * productAndQuantity.Item2[i]);
                Console.WriteLine($"{productAndQuantity.Item1[i].Name}\t {productAndQuantity.Item2[i]}\t {productAndQuantity.Item1[i].Price * productAndQuantity.Item2[i]}");
            }
            Console.WriteLine($"Total \t\t\t {price}");
        }
    }
}
