namespace Store.Domain.Entities.Account
{
    public class Address : BaseEntity
    {
        public string ZipCode { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
