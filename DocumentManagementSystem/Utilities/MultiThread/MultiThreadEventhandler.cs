namespace Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    public class MultiThreadEventhandler : IDisposable
    {
        private int threadCount = 0;
        private readonly ManualResetEvent reseter;
        public MultiThreadEventhandler(int threadCount)
        {
            this.threadCount = threadCount;
            this.reseter = new ManualResetEvent(false);
        }

        public void Set()
        {
            if(Interlocked.Decrement(ref this.threadCount) == 0)
            {
                this.reseter.Set();
            }
        }

        public void Dispose()
        {
            
            if(this.threadCount == 0)
            {
                this.reseter.Set();
            }
            else
            {
                this.reseter.WaitOne();
            }
        }
    }
}
