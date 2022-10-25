using System.ComponentModel.DataAnnotations;

namespace LuukAPICase.DTO
{
    public class AddressRequest
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
