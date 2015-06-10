
namespace Demo.Console.Client
{
    using Demo.Services.Interface;
    using WcfExtension;

    class Program
    {
        protected static void Main(params  string[] args)
        {
            System.Console.WriteLine("Run this demo with administrator...");
            System.Console.WriteLine("Service Contract Namespace：" + typeof(IDemoService).FullName);

            var client = WcfServiceLocator.Create<IDemoService>();

            System.Console.WriteLine("Client Proxy is Running...");
            while (true)
            {
                System.Console.WriteLine(client.SayHelloPeople(new People() { Name = "Demo GT" }));
                System.Console.ReadLine();
            }
        }
    }
}
