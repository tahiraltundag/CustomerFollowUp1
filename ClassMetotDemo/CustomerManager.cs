using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {

        List<Customer> customerList = new List<Customer>();

        public void Add(params Customer[] customers)
        {
            foreach(Customer customer in customers)
            {
                customerList.Add(customer);
                Console.WriteLine(customer.FirstName + " Kullanıcısı sisteme kaydedildi\n");
            }
        }

        public void Delete(params Customer[] customers)
        {
            foreach(Customer customer in customers)
            {
                if (customerList.Contains(customer)==true)
                {
                    customerList.Remove(customer);
                    Console.WriteLine(customer.FirstName + " Kullanıcısı sistemden silindi\n");
                }
                else
                {
                    Console.WriteLine("Müşteri bulunamadı\n");
                }
            }
        }

        public void List()
        {
            if(customerList.Count != 0)
            {
                Console.WriteLine("Müşeriler listeleniyor\n");
                foreach(Customer customer in customerList)
                {
                    Console.WriteLine(customer.FirstName);
                }
            }
            else
            {
                Console.WriteLine("Müşteri listesi boş\n");
            }
        }
    }
}
