using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6task3
{
    private class CacheItem
    {
        public TResult Result { get; }
        public DateTime Timestamp { get; }

        public CacheItem(TResult result, DateTime timestamp)
        {
            Result = result;
            Timestamp = timestamp;
        }
    }
}