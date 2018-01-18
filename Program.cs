using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace _net_core_2__0_and_angular_4
{
    public class Program
    {
        private static readonly Dictionary<string, string> defaults =
        new Dictionary<string, string> {
            { WebHostDefaults.EnvironmentKey, "development" }
        };

    public static void Main(string[] args) {
        var configuration =
            new ConfigurationBuilder()
                .AddInMemoryCollection(defaults)
                .AddEnvironmentVariables("ASPNETCORE_")
                .AddCommandLine(args)
                .Build();

        var host =
            new WebHostBuilder()
                .UseConfiguration(configuration)
                .UseKestrel()
                .UseUrls("http://localhost:5000")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

        host.Run();
        // host.Start();
        // var url = "http://localhost:5000/";
        // Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
       // OpenBrowser("http://localhost:5000/");
    }
    }
}
