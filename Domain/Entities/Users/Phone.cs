using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Store.Domain.Entities.Users
{
    public class Phone: BaseEntity
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        [Required,Phone]
        public string Number { get; set; }

        public int PersonId  { get; set; }
        public Person Person { get; set; }
    }
}
