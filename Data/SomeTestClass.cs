﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCO.Data
{
    public class SomeTestClass
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }
        public string Data3 { get; set; }
        public string Data4 { get; set; }

        public OtherType OtherTypeValue { get; set; }

        public class OtherType
        {
            public int ID { get; set; }
            public string Title { get; set; }
        }
    }
}
