using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class TestTempData
    {
        public int ID { get; set; }
        public int TestTempID { get; set; }
        public int TestTempColID { get; set; }
        public string StringValue { get; set; }
        public bool BoolValue { get; set; }
        public int? DropDownValueID { get; set; }
        public virtual TestTemp TestTemp { get; set; }
        public virtual TestTempCol TestTempCol { get; set; }
        public virtual Lookup DropDownValue { get; set; }
    }
}
