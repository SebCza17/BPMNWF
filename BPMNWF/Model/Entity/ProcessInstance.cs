using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.Entity
{
    class ProcessInstance
    {
        public string id { get; set; }
        public string url { get; set; }
        public object businessKey { get; set; }
        public bool suspended { get; set; }
        public bool ended { get; set; }
        public string processDefinitionId { get; set; }
        public string processDefinitionUrl { get; set; }
        public string activityId { get; set; }
        public object[] variables { get; set; }
        public string tenantId { get; set; }
        public bool completed { get; set; }


        public override string ToString()
        {
            return id;
        }
    }
}
