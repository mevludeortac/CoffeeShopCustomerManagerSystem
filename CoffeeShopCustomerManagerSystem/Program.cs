using System;
using CoffeeShopCustomerManagerSystem.Abstract;
using CoffeeShopCustomerManagerSystem.Concrete;
using CoffeeShopCustomerManagerSystem.Entities;

namespace CoffeeShopCustomerManagerSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            customerManager.Save(new Customer { DateOfBirth= new DateTime(1999,10,3), FirstName="herbin", LastName="ortaç", Id=56786543, TcId="432234567"});
        }
    }
}
