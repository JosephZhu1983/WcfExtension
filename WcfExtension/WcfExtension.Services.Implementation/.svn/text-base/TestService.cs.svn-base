using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfExtension.Services.Interface;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;

namespace WcfExtension.Services.Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "WcfExtension.Services.Implementation")]
    public class TestService : ITestService, ITestService2
    {
        public int Add(int x, int y)
        {
            //log.Log("测试日志");
            if (x == 0 && y == 0)
                throw new Exception("错误", new ArgumentException("内部错误"));
            return x + y;
        }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        public User GetUser(string name, int age)
        {
            return new User
            {
                Age = age,
                Name = name,
            };
        }

        public double Add2(double x, double y)
        {
            Thread.Sleep(100);
          
            return x + y;
        }


        public ITestContract TestData(ITestContract tc)
        {
            return tc;
        }


        public List<string> AddList(List<string> args)
        {

            return args;
        }
    }
}
