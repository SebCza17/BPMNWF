using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.DAO
{
    class ProcessDAO
    {

        private RestApp restApp;

        public ProcessDAO(RestApp restApp)
        {
            this.restApp = restApp;
        }

        public Entity.ProcessDefinitions getProcessDefinitions()
        {
            return JsonConvert.DeserializeObject<Entity.ProcessDefinitions>(restApp.makeGet("activiti-rest/service/repository/process-definitions/"));
        }

        public Entity.ProcessDefinition getProcessDefinition(string id)
        {
            return JsonConvert.DeserializeObject<Entity.ProcessDefinition>(restApp.makeGet("activiti-rest/service/repository/process-definitions/" + id));   
        }

        public Entity.ProcessInstances getProcessInstances()
        {
            return JsonConvert.DeserializeObject<Entity.ProcessInstances>(restApp.makeGet("activiti-rest/service/runtime/process-instances/"));
        }

        public Entity.ProcessInstance getProcessInstance(string id)
        {
            return JsonConvert.DeserializeObject<Entity.ProcessInstance>(restApp.makeGet("activiti-rest/service/runtime/process-instances/" + id));
        }

        public bool addProcessInstance(string id)
        {
            StringContent stringContent = new StringContent("{\"processDefinitionId\":\"" + id + "\"}", Encoding.UTF8, "application/json");
            return restApp.makePost("activiti-rest/service/runtime/process-instances/", stringContent);
        }
    }
}
