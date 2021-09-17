using System;
using CoffeeShopCustomerManagerSystem.Entities;

namespace CoffeeShopCustomerManagerSystem.Abstract
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer);
    }
}
