using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Store.Domain.Entities.Users
{
    public class Employee : Person
    {
        [MaxLength(10), Required]
        public string Registration { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

    }
}
