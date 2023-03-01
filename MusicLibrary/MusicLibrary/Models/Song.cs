using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MusicLibrary.Models;

public class Song
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; } = string.Empty;
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    public string? Genre { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string? Artist { get; set; }
    [StringLength(60, MinimumLength = 3)]
    public string? Album { get; set; }

}
