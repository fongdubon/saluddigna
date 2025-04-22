using System.ComponentModel.DataAnnotations;

namespace saluddigna.Shared.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; } = null!;
        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; } = null!;

        public ICollection<PatientCategory>? PatientCategories { get; set; }

        [Display(Name = "Categorías")]
        public int PatientCategoryNumber => PatientCategories == null ? 0 : PatientCategories.Count;

        public ICollection<PatientImage>? PatientImages { get; set; }

        [Display(Name = "Imágenes")]
        public int PatientImagesNumber => PatientImages == null ? 0 : PatientImages.Count;

        [Display(Name = "Imagén")]
        public string MainImage => PatientImages == null ? string.Empty : PatientImages.FirstOrDefault()!.Image;

    }
}
