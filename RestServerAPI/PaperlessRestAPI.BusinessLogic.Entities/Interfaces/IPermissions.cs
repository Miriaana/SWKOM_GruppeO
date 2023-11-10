using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.BusinessLogic.Entities.Interfaces
{
    public interface IPermissions
    {
        User[] Users { get; set; }
        Group[] Groups { get; set; }
    }
}
