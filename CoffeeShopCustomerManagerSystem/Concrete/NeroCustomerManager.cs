using System;
using CoffeeShopCustomerManagerSystem.Abstract;
using CoffeeShopCustomerManagerSystem.Entities;

namespace CoffeeShopCustomerManagerSystem.Concrete
{
    public class NeroCustomerManager: BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
