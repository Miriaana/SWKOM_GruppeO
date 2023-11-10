using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PaperlessRestAPI.DataAccess.Entities
{
    [Table("Correspondents")]
    public class Correspondents
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }

        public string Match { get; set; }
        public int MatchingAlgorithm { get; set; }
        public bool IsInsensitive { get; set; }

        // Foreign Key to What
        public int Owner { get; set; }

        // Foreign Key to LastCorrespondents
        public int LastCorrespondentsId { get; set; }
        public Correspondents LastCorrespondents { get; set; }
    }
}