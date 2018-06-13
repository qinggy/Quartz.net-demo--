using System;
using System.IO;
using Topshelf;

namespace QTDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));

            HostFactory.Run(x =>
            {
                x.UseLog4Net();

                x.Service<ServiceRunner>();

                x.RunAsLocalSystem();

                x.SetDescription("Quartz+TopShelf实现Windows服务作业调度的一个示例Demo");
                x.SetDisplayName("QuartzTopShelfDemo服务");
                x.SetServiceName("QuartzTopShelfDemoService");

                x.EnablePauseAndContinue();

            });
        }
    }
}
