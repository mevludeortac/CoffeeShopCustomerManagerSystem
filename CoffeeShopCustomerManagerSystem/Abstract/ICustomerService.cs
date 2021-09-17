using System;
using CoffeeShopCustomerManagerSystem.Entities;

namespace CoffeeShopCustomerManagerSystem.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
