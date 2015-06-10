using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Demo.Services.Implementation
{
    using Demo.Services.Interface;
    using System.ServiceModel;

    [ServiceBehavior(
        ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall,
        Namespace = "Demo.Services.Implementation")]
    public class DemoService : IDemoService
    {

        public void SayHelloOneWay()
        {
            var d = DateTime.Now.ToString("yyyyMMddhhmmss");

            System.IO.File.Create(d);
        }

        public string SayHelloString()
        {
            return "Hello Boy";
        }

        public string SayHelloPeople(People p)
        {
            return "Hello " + p.Name;
        }
    }
}
