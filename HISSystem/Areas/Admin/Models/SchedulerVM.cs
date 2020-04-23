using Data.Models;
using DevExtreme.NETCore.Demos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneticSystem.Areas.Admin.Models
{
    public class SchedulerVM
    {
        public IEnumerable<AppointmentExp> AppointmentExps { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; }
        public IEnumerable<SelectListItem> TestTemps { get; set; }
        public IEnumerable<SelectListItem> Genes { get; set; }
    }
}
