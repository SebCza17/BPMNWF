using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.DAO
{
    class DeploymentDAO
    {
        private RestApp restApp;
        public DeploymentDAO(RestApp restApp)
        {
            this.restApp = restApp;
        }
        public Entity.Deployments getDeployments()
        {
            return JsonConvert.DeserializeObject<Entity.Deployments>(restApp.makeGet("activiti-rest/service/repository/deployments/"));
        }

        public Entity.Deployment getDeployment(string id)
        {
            return JsonConvert.DeserializeObject<Entity.Deployment>(restApp.makeGet("activiti-rest/service/repository/deployments/" + id));
        }

        public bool delDeployment(string id)
        {
            return restApp.makeDelete("activiti-rest/service/repository/deployments/" + id);
        }

        public bool setDeployment()
        {
            //restApp.test("activiti-rest/service/repository/deployments/");

            return true;
        }

        public List<Entity.Resource> getListResources(string id)
        {
            return JsonConvert.DeserializeObject<List<Entity.Resource>>(restApp.makeGet("activiti-rest/service/repository/deployments/" + id + "/resources"));
        }
    }
}
