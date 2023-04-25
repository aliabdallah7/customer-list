using System.ComponentModel.DataAnnotations;

namespace customer_list.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }
}