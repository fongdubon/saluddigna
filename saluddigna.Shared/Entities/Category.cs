using System.ComponentModel.DataAnnotations;

namespace saluddigna.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        public ICollection<PatientCategory>? PatientCategories { get; set; }

        [Display(Name = "Pacientes")]
        public int PatientCategoriesNumber => PatientCategories == null ? 0 : PatientCategories.Count;
    }
}
