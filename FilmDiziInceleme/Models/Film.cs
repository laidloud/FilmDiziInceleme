using System.ComponentModel.DataAnnotations;
namespace FilmDiziInceleme.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Film adı boş bırakılamaz.")]
        public string Title { get; set; }

        [Required]
        public string Type { get; set; } // Film/Dizi

        public string Genre { get; set; }
        
        public int Year { get; set; }

        [Range(0, 10)]
        public float Rating { get; set; }

        [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
        public string Description { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
