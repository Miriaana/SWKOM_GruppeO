﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.BusinessLogic.Interfaces.Components
{
    public interface ISearchDocumentLogic
    {
        public List<string> searchDocuments(string Searchterm);
    }
}
