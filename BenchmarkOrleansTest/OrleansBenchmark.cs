using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkOrleansTest
{
    public class OrleansBenchmark
    {
        private IHost host;
        private IGrainFactory grainFactory;

        [GlobalSetup]
        public void GlobalSetup()
        {
            this.host = new HostBuilder()
               .UseOrleans(siloBuilder =>
               {
                   siloBuilder.UseLocalhostClustering();
               })
               .Build();

            this.grainFactory = host.Services.GetRequiredService<IGrainFactory>();
        }


        [GlobalCleanup]
        public void GlobalCleanup()
        {
            this.host?.Dispose();
        }

        [Benchmark]
        public async Task Benchmark()
        {
            var benchmarkGrain = this.grainFactory.GetGrain<IBenchmarkGrain>("test");
            await benchmarkGrain.DoStuff();
        }
    }
}
