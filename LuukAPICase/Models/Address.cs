using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace LuukAPICase.Models
{
    [Table("Address")]
    public class Address
    {
        
        [Required]
        [SwaggerSchema(ReadOnly = true)]
        public Guid Id { get; set; }
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

        public string GetAddress()
        {
            return $"{Street} {HouseNumber}, {ZipCode} {City}, {Country}";
        }
    }
}
