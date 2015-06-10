namespace QuickStart.Demo.Client
{
    using System;
    using System.Threading;
    using QuickStart.Services.Interface;
    using WcfExtension;

    class Program
    {
        protected static void Main(params string[] args)
        {
            Console.WriteLine("Wait 3 seconds");
            Thread.Sleep(3000);
            try
            {
                while (true)
                {
                    var proxy = WcfServiceLocator.Create<IQsService>();

                    var result = proxy.SayHelloWorld("Batman");

                    Console.WriteLine("Result is " + result);

                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
