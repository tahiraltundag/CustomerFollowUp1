using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer(1,"Sultan","Altundağ");

            Customer customer2 = new Customer(2,"Mehmet","Altundağ");

            Customer customer3 = new Customer(3,"Hatice","Altundağ");


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1, customer2, customer3);
            customerManager.Delete(customer3);
            customerManager.List();

        }
    }
}
