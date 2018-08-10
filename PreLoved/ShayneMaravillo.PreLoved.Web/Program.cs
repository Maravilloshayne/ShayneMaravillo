using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ShayneMaravillo.PreLoved.Web
{
    public class Program
    {
        public static object lPAddress { get; private set; }

        public static void Main(string[] args)
        {
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options => { options.Listen(IPAddress.Loopback, 6100); })
                .UseStartup<Startup>();
    }
}

}
