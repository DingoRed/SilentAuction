using System;
using System.ComponentModel.DataAnnotations;

namespace SilentAuction.Core.Entities
{
    /// <summary>
    /// Contact information for a donor
    /// </summary>
    public class Donor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DonorTypeId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string ContactName { get; set; }

        [MaxLength(100)]
        public string Street1 { get; set; }

        [MaxLength(100)]
        public string Street2 { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(10)]
        public string ZipCode { get; set; }

        [MaxLength(12)]
        public string Phone1 { get; set; }

        [MaxLength(10)]
        public string Extension1 { get; set; }

        [MaxLength(12)]
        public string Phone2 { get; set; }

        [MaxLength(10)]
        public string Extension2 { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
