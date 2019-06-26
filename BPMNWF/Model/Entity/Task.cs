using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.Entity
{
    class Task
    {
        public string id { get; set; }
        public string url { get; set; }
        public object owner { get; set; }
        public object assignee { get; set; }
        public object delegationState { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public DateTime createTime { get; set; }
        public object dueDate { get; set; }
        public int priority { get; set; }
        public bool suspended { get; set; }
        public string taskDefinitionKey { get; set; }
        public string tenantId { get; set; }
        public object category { get; set; }
        public object formKey { get; set; }
        public object parentTaskId { get; set; }
        public object parentTaskUrl { get; set; }
        public string executionId { get; set; }
        public string executionUrl { get; set; }
        public string processInstanceId { get; set; }
        public string processInstanceUrl { get; set; }
        public string processDefinitionId { get; set; }
        public string processDefinitionUrl { get; set; }
        public object[] variables { get; set; }
        
        public Form form { get; set; }

        public override string ToString()
        {
            return name;
        }
    }


}
