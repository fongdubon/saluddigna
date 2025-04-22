using System.ComponentModel.DataAnnotations;

namespace saluddigna.Shared.DTOs
{
    public class ImageDTO
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        public List<string> Images { get; set; } = null!;
    }
}
