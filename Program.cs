using ConvinienceStoreModel.Customers;
using ConvinienceStoreModel.Products;
using ConvinienceStoreModel.Stores;
using ConvinienceStoreModel.Workers;
using System;
using System.Collections.Generic;

namespace ConvinienceStoreModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing my Convinience Store Project");
            #region Products
            var listOfProduct = new List<Product>()
            {
                new Product("Cookies  ",78m),
                new Product("Noodles  ",18m),
                new Product("Beer     ",38m),
                new Product("Chocolate",38m),
            };
            var listOfQuantities = new List<int>() { 1, 3, 4, 5 };
            #endregion
            #region Testing The Cashier Class
            Console.WriteLine("\nTest1: Cashier Sell Product Method");
            Cashier cashier = new Cashier("Dozie", "Opara", "21, Asajon Way");
            Cashier cashier2 = new Cashier("Ben", "Yiba", "21, Asajon Way");
            var productAndQuantityList = new Tuple<List<Product>, List<int>>(listOfProduct, listOfQuantities);
            cashier.SellProduct(productAndQuantityList, 50000m);
            #endregion
            #region Creating Customer
            Console.WriteLine("\nTest2: Customer Buy Product Method");
            var customer = new Customer("Ïmooluwa", "IM@oluwa.com");
            customer.BuyProduct(productAndQuantityList, 780.8m);
            #endregion

            #region Store And Store Manager
            Console.WriteLine("\nTest3: Manager Hires Cashier Method");
            Store myStore = new Store()
            {
                StoreName = "Shop Rite",
                Address = "Decagon Road",
                Cashiers = new List<Cashier>() { cashier },
                Products = listOfProduct,
            };
            Manager manager = myStore.StoreManager;
            manager.SetManagerDetails("Tunde", "Imhonode");
            myStore.StoreManager.HireCashier("Dozie", "Opara", "DozieWay, Lagos", myStore); 
            #endregion
        }
    }
}
