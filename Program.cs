
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System.IO;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder().UseKestrel()
           .UseStartup<Startup>()
           .UseContentRoot(Directory.GetCurrentDirectory())
           .UseUrls("http://localhost:8888/","http://localhost:9999/")
            .Build().Run();
        }
    }
}
