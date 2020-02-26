using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class MedicalHistory : BaseEntity
    {
        public int? PatientTypeID { get; set; }
        public Nullable<DateTime> LastVisit{get;set;}
        public int? AdmissionTypeID { get; set; }
        public int? PayTypeID { get; set; }
    }
}
