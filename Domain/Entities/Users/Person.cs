using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entities.Users
{
    public abstract class Person: User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
