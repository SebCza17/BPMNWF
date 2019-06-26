using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.Entity
{
    class Tasks
    {

        public Task[] data { get; set; }
        public int total { get; set; }
        public int start { get; set; }
        public string sort { get; set; }
        public string order { get; set; }
        public int size { get; set; }
        
    }
}
