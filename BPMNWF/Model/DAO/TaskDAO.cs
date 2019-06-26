using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.DAO
{
    class TaskDAO
    {
        private RestApp restApp;

        public TaskDAO(RestApp restApp)
        {
            this.restApp = restApp;
        }

        public Entity.Task getTask(string id)
        {
            return JsonConvert.DeserializeObject<Entity.Task>(restApp.makeGet("activiti-rest/service/runtime/tasks/" + id));
        }

        public Entity.Tasks getTasks()
        {
            return JsonConvert.DeserializeObject<Entity.Tasks>(restApp.makeGet("activiti-rest/service/runtime/tasks/"));
        }

        internal bool endTask(string id)
        {
            StringContent stringContent = new StringContent("{\"action\" : \"complete\"}", Encoding.UTF8, "application/json");

            return restApp.makePost("activiti-rest/service/runtime/tasks/" + id, stringContent);
        }
    }
}
