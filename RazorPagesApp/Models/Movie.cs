// Models/Movie.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesApp.Models
{
    public class Movie
    {
        [Key]  // Указывает, что это первичный ключ
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Автоинкремент
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Title { get; set; }
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string? Rating { get; set; }
    }
}