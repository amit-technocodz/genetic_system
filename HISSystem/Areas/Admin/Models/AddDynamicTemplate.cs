using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneticSystem.Areas.Admin.Models
{
    public class AddDynamicTemplate
    {
        public Template Template { get; set; }
        public List<TemplateColumn> TemplateColumns { get; set; }
        public TemplateData TemplateData { get; set; }
        public List<TemplateData> TemplateDataList { get; set; }
    }
}
