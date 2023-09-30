using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzGorev
{
    public class Gorev : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Görevdeyiz...");
            //await Task.CompletedTask;
        }

    }
}
