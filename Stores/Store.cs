using ConvinienceStoreModel.Customers;
using ConvinienceStoreModel.Workers;
using ConvinienceStoreModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvinienceStoreModel.Stores
{
    public class Store
    {
        public  Manager StoreManager { get; set; } = Manager.StoreManager;
        public  string StoreName { get; set; }
        public string Address { get; set; }
        public List<Cashier> Cashiers { get; set; } = new List<Cashier>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public Store()
        {

        }
        public Store(string storeName, string address)
        {
            StoreName = storeName;
            Address = address;
        }
    }
}
