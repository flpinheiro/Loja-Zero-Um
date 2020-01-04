using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store.Domain.Entities.Account
{
    public abstract class User : BaseEntity
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, PasswordPropertyText, DataType(DataType.Password), MinLength(8, ErrorMessage = "Password must have at least 8 characters.")]
        public string PassWord { get; set; }
    }
}
