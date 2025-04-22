namespace saluddigna.Shared.Entities
{
    public class PatientCategory
    {
        public int Id { get; set; }

        public Patient Patient { get; set; } = null!;

        public int PatientId { get; set; }

        public Category Category { get; set; } = null!;

        public int CategoryId { get; set; }
    }
}
