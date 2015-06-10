using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfExtension.Services.Implementation;
using System.Threading;

namespace WcfExtension.Hosts.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            ServerManager.StartService(typeof(TestService));
            Console.WriteLine("TestService Started...");
            Console.ReadLine();
        }
    }
}
