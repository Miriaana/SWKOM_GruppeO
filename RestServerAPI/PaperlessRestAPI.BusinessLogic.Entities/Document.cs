using PaperlessRestAPI.BusinessLogic.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperlessRestAPI.DataAccess.Entities;

namespace PaperlessRestAPI.BusinessLogic.Entities
{
    public class DocumentRepo
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        // ToDo: Array cannot be mapped to database like that (new Table Tags, new Table DocumentTags (mapping table), foreignkeys) 
        [NotMapped]
        public int[] Tags { get; set; } //Should be an array? fixed size? (there should not be any dynamic size change of the tags array, array is fine)

        public DateTime Created { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Added { get; set; }
        public string Archive_Serial_Number { get; set; }
        public string Original_File_Name { get; set; }
        public string Archived_File_Name { get; set; }
        public int? Storage_Path { get; set; }
        public bool User_Can_Change { get; set; }

        public byte[] Data { get; set; }

        public int? CorrespondentId { get; set; }
        public Correspondents? Correspondent { get; set; } //Correspondent as Object?

        public int? DocumentTypeId { get; set; }
        public DocumentType? Document_Type { get; set; }

        public int? OwnerId { get; set; }
        public User Owner { get; set; }

        /// <summary>
        /// One to Many relationship with Notes
        /// </summary>
        public Notes[] notes { get; set; }
    }
}
