namespace QuickStart.Demo.Host
{
    using System;
    using QuickStart.Services.Implememtation;
    using WcfExtension;

    class Program
    {
        protected static void Main(params string[] args)
        {
            try
            {
                ServerManager.StartService(typeof(QsService));
                Console.WriteLine("Service is running...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
