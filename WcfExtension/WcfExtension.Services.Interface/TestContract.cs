using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfExtension.Services.Interface
{
    [DataContract]
    public class TestContract : ITestContract
    {
        [DataMember(Order = 1)]
        public string D1 { get; set; }

        [DataMember(Order = 2)]
        public string D2 { get; set; }

        [DataMember(Order = 3)]
        public string D3 { get; set; }

        [DataMember(Order = 4)]
        public string D4 { get; set; }

        [DataMember(Order = 5)]
        public string D5 { get; set; }

        [DataMember(Order = 6)]
        public string D6 { get; set; }

        [DataMember(Order = 7)]
        public string D7 { get; set; }

        [DataMember(Order = 8)]
        public string D8 { get; set; }

        [DataMember(Order = 9)]
        public string D9 { get; set; }

        [DataMember(Order = 10)]
        public string D10 { get; set; }
    }
}
