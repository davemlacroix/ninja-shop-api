using System.ComponentModel.DataAnnotations;

namespace ninja_shop.core.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required] 
        public string FirstName { get; set; }

        [Required] 
        public string LastName { get; set; }

        [Required] 
        public string Email { get; set; }

        [Required] 
        public string Address { get; set; }
        
        [Required] 
        public string State { get; set; }

        [Required] 
        public string Zip { get; set; }

        [Required] 
        public string CCName { get; set; }
        
        [Required] 
        public string CCNumber { get; set; }

        [Required] 
        public string CCExp { get; set; }

        [Required] 
        public string CCCVV { get; set; }
 }
}