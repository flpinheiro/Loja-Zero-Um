using System.ComponentModel.DataAnnotations;

namespace Store.Domain.Entities.Account
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
