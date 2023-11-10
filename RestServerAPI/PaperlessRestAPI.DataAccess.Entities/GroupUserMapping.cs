using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Entities
{
    [Table("GroupUserMappings")]
    public class GroupUserMapping
    {
        [Required]
        public int GroupId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
