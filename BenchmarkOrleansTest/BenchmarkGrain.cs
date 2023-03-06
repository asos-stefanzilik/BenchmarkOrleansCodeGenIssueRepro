using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkOrleansTest
{
    public interface IBenchmarkGrain : IGrainWithStringKey
    {
        ValueTask<int> DoStuff();
    }
    public class BenchmarkGrain : IBenchmarkGrain
    {
        public async ValueTask<int> DoStuff()
        {
            return 1;
        }
    }
}
