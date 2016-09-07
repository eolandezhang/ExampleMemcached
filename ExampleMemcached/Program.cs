using System;
using Enyim.Caching;

namespace ExampleMemcached
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new MemcachedClient();
            object customer;
            if (!mc.TryGet("Customer", out customer))
            {
                mc.Store(Enyim.Caching.Memcached.StoreMode.Add, "Customer", "Lucy");
            };
            Console.WriteLine((string) customer);
            Console.Read();
        }
    }
}
