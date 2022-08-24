using Microsoft.AspNetCore.Hosting;
using AdventureWorksNS.Data;

namespace WebApplication1
{
    public class Program
    {   public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartUp>();
                }).Build().Run();
        }
    }
}