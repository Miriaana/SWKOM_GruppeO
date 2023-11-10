using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.BusinessLogic.Entities.Interfaces
{
    public interface INote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public Document Document { get; set; }
        public User user { get; set; }

    }
}
