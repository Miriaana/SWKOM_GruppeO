using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Entities
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateJoined { get; set; }

        public bool IsStaff { get; set; }

        public bool IsActive { get; set; }
        public bool IsSuperuser { get; set; }

        public int[] Groups { get; set; }

        public string[] UserPermissions { get; set; }
        public string[] InheritedPermissions { get; set; }
        //public List<GroupUserMapping> Groups { get; set; }
    }
}
