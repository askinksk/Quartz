using System;
using System.Threading.Tasks;
using Quartz;

public class ShowDateTimeJob: IJob
{
    public Task Execute(IJobExecutionContet context)
    {
        var now = DateTime.Now.ToString("HH : mm : ss");
        console.WriteLine($"Merhaba, saat şuan {now}");
        return Task.CompletedTask;
    }
}