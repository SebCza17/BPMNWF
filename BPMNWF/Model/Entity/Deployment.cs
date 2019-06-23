using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.Entity
{
    class Deployment
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime deploymentTime { get; set; }
        public string category { get; set; }
        public string url { get; set; }
        public object tenantId { get; set; }
    }
}
