﻿using System;
using CoffeeShopCustomerManagerSystem.Abstract;
using CoffeeShopCustomerManagerSystem.Entities;


namespace CoffeeShopCustomerManagerSystem.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }


        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);

            }
            else
            {
                throw new Exception("unvalid person");

            }

        }

        
    }
}
