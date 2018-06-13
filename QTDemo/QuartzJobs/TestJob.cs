using Quartz;
namespace QTDemo.QuartzJobs
{
    public sealed class TestJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            CommonHelper.AppLogger.InfoFormat("TestJob测试");

        }
    }
}
 