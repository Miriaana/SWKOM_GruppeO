using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Entities
{
    [Table("Notes")]
    public class Notes
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int DocumentId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        public DateTime Created { get; set; }
    }
}
