using System.ComponentModel.DataAnnotations;

namespace SilentAuction.Core.Entities
{
    /// <summary>
    /// Donor Type
    /// </summary>
    public class DonorType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
