using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Entities
{
    [Table("PermissionNames")]
    public class PermissionName
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
