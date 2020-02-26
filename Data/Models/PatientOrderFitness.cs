﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
  public  class PatientOrderFitness
    {
        public int ID { get; set; }
        public int? ConsumptionTypeID { get; set; }
        public string EffectedGood { get; set; }
        public string EffectedBad { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public virtual Lookup ConsumptionType { get; set; }
        public int OrderID { get; set; }
        public virtual PatientOrder Order { get; set; }
        public virtual List<PatientOrderEffectedGeneFitness> PatientOrderEffectedGeneFitnessList { get; set; }
        [NotMapped]
        public string[] EffectedGenes { get; set; }
    }
}
