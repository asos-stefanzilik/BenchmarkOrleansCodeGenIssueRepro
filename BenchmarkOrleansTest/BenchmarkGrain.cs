using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace BenchmarkOrleansTest
{
    public interface IBenchmarkGrain :  IGrainWithStringKey
    {
        ValueTask<int> DoStuff();
    }
    public sealed class BenchmarkGrain : Grain, IBenchmarkGrain
    {
        public async ValueTask<int> DoStuff()
        {
            return 1;
        }
    }
}
