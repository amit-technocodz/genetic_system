using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneticSystem.Areas.Admin.Models
{
    public class ClientOrderViewModel
    {
        public ClientOrder ClientOrder { get; set; }
        public List<ClientOrderData> ClientOrderData { get; set; }
        public List<TemplateData> TemplateDataList { get; set; }
        public List<Template> TemplateList { get; set; }
        public List<ClientOrder> ClientOrderList { get; set; }
    }
}
