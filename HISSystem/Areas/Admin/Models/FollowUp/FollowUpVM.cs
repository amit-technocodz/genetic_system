using Data.Helpers;
using Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneticSystem.Areas.Admin.Models.FollowUp
{
    public class FollowUpVM
    {
        public ClientOrderViewModel ClientOrderViewModel { get;set;}
        public PagedData<ClientOrder> ClientOrderList { get; set; }
        public User User { get; set; }
        public List<SelectListItem> patientList { get; set; }
        public FollowUpByDoc FollowUpByDoc { get; set; }
        public List<FollowUpByDocResult> FollowUpByDocResultList { get;set;}
        public List<FollowUpByDocConv> FollowUpByDocConvList { get; set; }
    }
}
