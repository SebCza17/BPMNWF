﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMNWF.Model.Entity
{
    public class FormProperty
    {
        public string Id;
        public string Name;
        public string Type;
        public List<EnumValue> EnumValues;
    }
}
