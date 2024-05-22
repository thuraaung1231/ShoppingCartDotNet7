using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDTO.Product
{
    [Table("productdb")]
    public class ProductModel
    {
        [Key]
        [Required]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int TotalItem { get; set; }
        [Required]
        public string Description { get; set; }
        public bool Is_delete { get; set; }
        [Required]
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
