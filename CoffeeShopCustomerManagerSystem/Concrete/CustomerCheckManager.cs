using System;
using CoffeeShopCustomerManagerSystem.Abstract;
using CoffeeShopCustomerManagerSystem.Entities;

namespace CoffeeShopCustomerManagerSystem.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            
            return true;
        }
    }
}
