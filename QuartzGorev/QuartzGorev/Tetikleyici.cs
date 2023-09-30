using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzGorev
{
    public class Tetikleyici
    {
        public async Task<IScheduler> Baslat()
        {
            ISchedulerFactory schedFact = new StdSchedulerFactory();
            IScheduler sched = await schedFact.GetScheduler();
            if (!sched.IsStarted)
            {
                sched.Start();
            }
            return sched;
        }
        public async void GoreviTetikle()
        {
            IScheduler sched = await Baslat();

            IJobDetail Gorev = JobBuilder.Create<Gorev>().WithIdentity("Gorev", null).Build();

            ISimpleTrigger TriggerGorev = (ISimpleTrigger)TriggerBuilder.Create().WithIdentity("Gorev").StartAt(DateTime.UtcNow).WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();
            sched.ScheduleJob(Gorev, TriggerGorev);
        }
    }
}
