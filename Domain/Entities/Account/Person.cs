using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.Domain.Entities.Account
{
    public abstract class Person: User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
