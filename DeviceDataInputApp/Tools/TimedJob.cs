using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;
using System;
using log4net;

namespace DeviceDataInputApp.Tools
{
    /// <summary>
    /// 定时工作
    /// </summary>
    public class TimedJob
    {
        private ILog log;
        public TimedJob()
        {
            log = LogManager.GetLogger(Startup.repository.Name, typeof(TimedJob));
        }
        /// <summary>
        /// 触发工作
        /// </summary>
        /// <returns></returns>
        public async Task TriggerJob()
        {
            try
            {
                StdSchedulerFactory factory = new StdSchedulerFactory();
                IScheduler scheduler = await factory.GetScheduler();
                //启动    
                await scheduler.Start();
                //定义工作，是在我们的ObtainingRemoteData类
                IJobDetail job = JobBuilder.Create<ObtainingRemoteData>()
                    .WithIdentity("job1", "group1")
                    .Build();
                //触发作业现在运行，然后每隔60秒重复一次。
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .StartNow()
                    .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(Application<object>.Timing).RepeatForever())
                    .Build();
                //告诉quartz使用我们的触发器来安排作业
                await scheduler.ScheduleJob(job, trigger);
                //一些睡眠来显示发生了什么
                // await Task.Delay(TimeSpan.FromSeconds(60));
                //最后，当准备关闭程序时关闭调度程序。
                // await scheduler.Shutdown();
            }
            catch (Exception ex)
            {
                var error = ex.Message;//测试=》获取程序错误的信息
                log.Info(ex.ToString());
            }
        }
    }
}
