using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store.Domain.Entities.Account
{
    public class User : BaseEntity
    {
        private string _email;
        [Required, EmailAddress]
        public string Email { get => _email; set => _email = value.ToLower(); }
        [Required, PasswordPropertyText, DataType(DataType.Password), MinLength(8, ErrorMessage = "Password must have at least 8 characters.")]
        public string PassWord { get; set; }
    }
}
