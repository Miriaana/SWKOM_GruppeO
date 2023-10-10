using PaperlessRestAPI.BusinessLogic.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.BusinessLogic.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public Correspondents? Correspondent { get; set; } //Correspondent as Object?
        public DocumentTypes? Document_Type { get; set; }
        public int? Storage_Path { get; set; }
        public string Title;
        public string Content;
        public int[] Tags { get; set; } //Should be an array? fixed size?
        public DateTime Created { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Added { get; set; }
        public string Archive_Serial_Number { get; set; }
        public string Original_File_Name { get; set; }
        public string Archived_File_Name { get; set; }


        public User Owner { get; set; }
        public bool User_Can_Change { get; set; }
        public INote[] notes { get; set; }

    }
}
