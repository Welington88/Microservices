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
        public int Id { get; set; }

        public String? ProductName { get; set; }

        public String? Description { get; set; }

        public int Amount { get; set; }
        
    }
}