using System;
using CoffeeShopCustomerManagerSystem.Entities;

namespace CoffeeShopCustomerManagerSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("save to database" + customer.FirstName + customer.LastName);
        }
    }

}
