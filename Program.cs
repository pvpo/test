using System;
using System.IO;
using ConsoleApplication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Visual_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .UseIISIntegration()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .Build();
            host.Run();        
        }
    }
}
