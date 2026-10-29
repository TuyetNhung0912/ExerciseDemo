using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace ExerciseDemo.Infrastructure.Caching
{
    public class MemoryCacheService
    {
        private readonly IMemoryCache memoryCache;

        public MemoryCacheService(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }
        public void Set<T>(string key, T value, TimeSpan expiration)
        {
            this.memoryCache.Set(key, value, expiration);
        }

        public bool TryGetValue<T>(string key, out T? value)
        {
            return this.memoryCache.TryGetValue(key, out value);
        }

        public void Remove(string key)
        {
            this.memoryCache.Remove(key);
        }
    }


}
