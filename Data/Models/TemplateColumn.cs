using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class TemplateColumn
    {
        public int ID { get; set; }
        public int TemplateID { get; set; }
        public int TemplateFieldID { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public virtual Template Template { get; set; }
        public virtual Lookup TemplateField { get; set; }
    }

}
