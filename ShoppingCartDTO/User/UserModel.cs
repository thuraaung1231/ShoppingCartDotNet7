using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDTO.User
{
    [Table("userdb")]
    public class UserModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(11,ErrorMessage ="Password Must be at least 8 charactor long",MinimumLength =8)]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password))]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Is_delete { get; set; }
    }
}
