using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.DAO
{
    class FormDAO
    {

        private RestApp restApp;

        public FormDAO(RestApp restApp)
        {
            this.restApp = restApp;
        }


        public bool postForm(Entity.FormData formData)
        {

            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var serialized = JsonConvert.SerializeObject(formData, serializerSettings);
            StringContent stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");

            return restApp.makePost("activiti-rest/service/form/form-data/", stringContent);
        }

        public Entity.Form getForm(string id)
        {
            return JsonConvert.DeserializeObject<Entity.Form>(restApp.makeGet("activiti-rest/service/form/form-data?taskId=" + id));
        }
    }
}
