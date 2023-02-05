using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Discount.API.Entities
{
    [Table("Coupon")]
    public class Coupon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = " O Campo {0} pode ter no máximo {1} e minimo {2} caracteres ", MinimumLength = 2)]
        public String? ProductName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = " O Campo {0} pode ter no máximo {1} e minimo {2} caracteres ", MinimumLength = 2)]
        public String? Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        
    }
}