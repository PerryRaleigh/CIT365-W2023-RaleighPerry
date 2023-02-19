using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Data.Models
{
    public class ScriptureEntry
    {
        public int Id { get; set; }

        [Required]
        public string? Volume { get; set; }

        [MinLength(4, ErrorMessage = "Book must be at least 4 characters, type Section for Doctrine and Covenants scripture entries")]
        [Required]
        public string? Book { get; set; }
        
        [Required]
        public int Chapter { get; set; }

        [Required]
        public int FromVerse { get; set; }

        public int? ToVerse { get; set; }

        [MinLength(10, ErrorMessage = "Note should be at least 10 characters with meaningful content")]
        [Required]
        public string Note { get; set; } = string.Empty;
        
        public DateTime Created { get; set; }
    }
}
