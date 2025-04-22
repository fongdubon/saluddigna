using System.ComponentModel.DataAnnotations;

namespace saluddigna.Shared.Entities
{
    public class PatientImage
    {
        public int Id { get; set; }

        public Patient Patient { get; set; } = null!;

        public int PatientId { get; set; }

        [Display(Name = "Imagen")]
        public string Image { get; set; } = null!;
    }
}
