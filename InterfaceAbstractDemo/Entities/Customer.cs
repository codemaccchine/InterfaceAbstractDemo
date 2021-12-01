// See https://aka.ms/new-console-template for more information

using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities // Note: actual namespace depends on the project name.
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

    }
}
