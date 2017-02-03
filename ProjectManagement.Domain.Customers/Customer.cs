using ProjectManagement.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Customers
{
    public class Customer:States.CustomerState
    {
        public string Drescription { get; private set; }
        public string ShortName { get; private set; }
        public decimal Budget { get; private set; }
        public CustomerType CustomerType { get; private set; }
        public CustomerStatus CustomerStatus { get;private set;}
        public ICollection<Address> Address { get; private set; }
        public ICollection<Person> Contacts { get; private set; }



    }
}
