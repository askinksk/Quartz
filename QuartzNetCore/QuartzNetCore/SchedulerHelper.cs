using Quartz.Impl;
using Quartz;

namespace QuartzNetCore
{
    public static class SchedulerHelper
    {
        public static async void SchedulerSetup()
        {
            var _scheduler = await new StdSchedulerFactory().GetScheduler();
            await _scheduler.Start();

            var showDateTimeJob = JobBuilder.Create<ShowDateTimeJob>()
                .WithIdentity("ShowDateTimeJob")
                .Build();
            var trigger = TriggerBuilder.Create()
                .WithIdentity("ShowDateTimeJob")
                .StartNow()
                .WithSimpleSchedule(builder => builder.WithIntervalInMinutes(1).RepeatForever())
                .Build();

            var result = await _scheduler.ScheduleJob(showDateTimeJob, trigger);
        }
    }
}
