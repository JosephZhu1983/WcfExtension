using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfExtension.Services.Interface;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace WcfExtension.Clients.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            while (true)
            {
                try
                {
                    Console.WriteLine(WcfServiceLocator.Create<ITestService>().GetUser("zhuye", 28).Name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //try
                //{
                //    WcfServiceLocator.Create<ITestService>().Hello();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

                Console.WriteLine("press any key to start another invoke!");
                Console.ReadLine();
            }

            //Debug.Listeners.Add(new TextWriterTraceListener(AppDomain.CurrentDomain.BaseDirectory + "/log.txt"));
            //Debug.AutoFlush = true;
            //string data = new string('a', 1000);
            //var scf = WcfServiceLocator.Create<ITestService>();
            //try
            //{
            //    Console.WriteLine(scf.TestData(new TestContract
            //    {
            //        D1 = "aa",
            //    }).D1);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //var it = 1000;

            //Stopwatch sw = Stopwatch.StartNew();


            //Console.WriteLine("开始");
            //Parallel.For(0, it, i =>
            //{

            //    scf.TestData(new TestContract
            //    {
            //        D1 = data + new Guid(),
            //        D2 = data + new Guid(),
            //        D3 = data + new Guid(),
            //        D4 = data + new Guid(),
            //        D5 = data + new Guid(),
            //        D6 = data + new Guid(),
            //        D7 = data + new Guid(),
            //        D8 = data + new Guid(),
            //        D9 = data + new Guid(),
            //        D10 = data + new Guid(),
            //    });


                //scf.Add(i, 1);
                // 数据库里配置的是200个
                //var counts = 100;
                //var list = new List<string>();
                //for (var xi = 0; xi < counts; xi++)
                //{
                //    list.Add(xi.ToString());
                //}
                //scf.AddList(list);


               
            //});


            //Parallel.For(0, it, i =>
            //{
            //   // var scf = WcfServiceLocator.Create<ITestService2>();
            //    try
            //    {
            //        scf.Add(i, 1);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //});

            //Console.WriteLine("总时间：" + sw.ElapsedMilliseconds);
            //Console.WriteLine("每秒：" + it * 1000 / sw.ElapsedMilliseconds);
            
            Console.ReadLine();
        }
    }
}
