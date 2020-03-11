using System;
using Learning.Services;

namespace Learning.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryDataBase cls = new QueryDataBase();
            cls.GetVersionAsync();
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
