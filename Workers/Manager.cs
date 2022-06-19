using ConvinienceStoreModel.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvinienceStoreModel.Workers
{
    public class Manager : Staff
    {
        private static Manager _storeManager = new Manager();
        public static Manager StoreManager
        {
            get { return _storeManager; }
        }

        public void SetManagerDetails(string firstName, string lastName)
        {
            _storeManager.LastName = lastName;
            _storeManager.FirstName = firstName;
            _storeManager.EmployeeID = LastName + "." + FirstName[0] + LastName[0];
        }

        public void HireCashier(string firstName, string lastName, string address, Store store)
        {
            var cashier = new Cashier(firstName, lastName, address);
            store.Cashiers.Add(cashier);
            Console.WriteLine($"You have been hired and your employee Id is {cashier.EmployeeID}");
        }
    }
}
