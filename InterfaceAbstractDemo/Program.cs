// See https://aka.ms/new-console-template for more information

using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {Id= 1, DateOfBirth = new DateTime(1993, 5, 12), FirstName = "Cahit", LastName = "Arslan", NationalityId = "57645844143" });



            Console.ReadLine();
        }
    }
}
