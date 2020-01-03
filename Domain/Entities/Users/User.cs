using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Store.Domain.Entities.Users
{
    public abstract class User : BaseEntity
    {
        [Required, EmailAddress]
        public string Name { get; set; }
        [Required, PasswordPropertyText, DataType(DataType.Password), MinLength(8, ErrorMessage = "Password must have at least 8 characters.")]
        public string PassWord { get; set; }
    }
}
