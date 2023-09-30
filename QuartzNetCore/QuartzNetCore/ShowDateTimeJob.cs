using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNetCore
{
    public class ShowDateTimeJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            var now = DateTime.Now.ToString("HH : mm : ss");
            Console.WriteLine($" Merhaba, saat şuan {now}");
            return Task.CompletedTask;
        }
    }
}
