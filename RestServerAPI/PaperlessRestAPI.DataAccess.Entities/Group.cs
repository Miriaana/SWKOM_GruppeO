using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Entities
{
    [Table("Groups")]
    public class Group
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<PermissionGroupMapping> Permissions { get; set; }
    }
}
