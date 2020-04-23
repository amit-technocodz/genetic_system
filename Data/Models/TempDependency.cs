using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Linq;

namespace Data.Models
{
    public class TempDependency
    {
        public int ID { get; set; }
        public int? ColID { get; set; }
        public int? ChkBoxID { get; set; }
        public bool? DependentYes { get; set; }
        public bool? DependentNo { get; set; }
        [ForeignKey("ColID")]
        public virtual TemplateColumn Col { get; set; }
        [ForeignKey("ChkBoxID")]
        public virtual TemplateColumn ChkBox { get; set; }
    }

    //public class Context : DbContext
    //{

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<TempDependency>()
    //                    .HasOne(m => m.Col)
    //                    .WithOne(t => t.ColIDTempDependencies)
    //                    .HasForeignKey<TempDependency>(m => m.ColID);

    //        modelBuilder.Entity<TempDependency>()
    //                    .HasOne(m => m.ChkBox)
    //                    .WithMany(t => t.ChkBoxTempDependencies)
    //                    .HasForeignKey(m => m.ChkBoxID);
    //    }
    //}
}
