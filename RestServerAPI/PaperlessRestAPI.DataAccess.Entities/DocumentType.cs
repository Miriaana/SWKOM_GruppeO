// using PaperlessRestAPI.DataAccess.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Entities
{
    public class DocumentType
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public string Slug { get; set; }

        [Required]
        public string Name { get; set; }
        public string Match { get; set; }

        public int? MatchingAlgorithm { get; set; }

        public bool? IsInsensitive { get; set; }

        public int Document_Count { get; set; }


        public int? Owner { get; set; }

        // public IPermissions View { get; set; }
        // public IPermissions Change { get; set; }

    }
}
