using System.ComponentModel.DataAnnotations;

namespace Store.Domain.Entities.Account
{
    public class Employee : Person
    {
        [MaxLength(10), Required]
        public string Registration { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

    }
}
