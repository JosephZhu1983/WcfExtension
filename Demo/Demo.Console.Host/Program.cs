
using System;
using Demo.Services.Interface;

namespace Demo.Console.Host
{
    using Demo.Services.Implementation;
    using WcfExtension;

    class Program
    {
        protected static void Main(params  string[] args)
        {
            System.Console.WriteLine("Run this demo with administrator...");
            System.Console.WriteLine("Service Contract Namespace：" + typeof(IDemoService).FullName);
            System.Console.WriteLine("Service Type Namespace：" + typeof(DemoService).FullName);
            
            ServerManager.StartService(typeof(DemoService));

            System.Console.WriteLine("Program is end");
            System.Console.ReadLine();
        }
    }
}
