using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.Entity
{
    public class ProcessDefinition
    {
        public string id { get; set; }
        public string url { get; set; }
        public int version { get; set; }
        public string key { get; set; }
        public string category { get; set; }
        public bool suspended { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string deploymentId { get; set; }
        public string deploymentUrl { get; set; }
        public bool graphicalNotationDefined { get; set; }
        public string resource { get; set; }
        public string diagramResource { get; set; }
        public bool startFormDefined { get; set; }


        public override string ToString()
        {
            return id;
        }
    }

}
