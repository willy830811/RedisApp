using StackExchange.Redis;
using System;

namespace RedisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            var db = redis.GetDatabase();
            db.StringSet("foo", 1688);
        }
    }
}
