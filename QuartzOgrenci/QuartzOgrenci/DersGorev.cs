using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzOgrenci
{
    internal class DersGorev : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            JobDataMap data = context.JobDetail.JobDataMap;
            Console.WriteLine($"{data.GetString("Adi")} {data.GetString("SoyAdi")} tek ayakta bekliyor...");
        }
    }
}
