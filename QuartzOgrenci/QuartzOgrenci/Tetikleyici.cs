using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzOgrenci
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
        public Ogrenci Ogrenci { get; set; }
        public async void DersTetikte()
        {
            IScheduler sched = await Baslat();
            IJobDetail DersGorev = JobBuilder.Create<DersGorev>().WithIdentity("DersGorev", null).UsingJobData("Adi", Ogrenci.Adi).UsingJobData("SoyAdi", Ogrenci.SoyAdi).Build();

             ISimpleTrigger TriggerDersGorev = (ISimpleTrigger)TriggerBuilder.Create().WithIdentity("DersGorev").StartAt(DateTime.UtcNow).WithSimpleSchedule(x => x.WithIntervalInSeconds(1).WithRepeatCount(20)).Build();
            sched.ScheduleJob(DersGorev, TriggerDersGorev);
        }
    }
}
