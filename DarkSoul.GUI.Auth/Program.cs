using DarkSoul.Core.Attribute;
using System;
using System.Reflection;

namespace DarkSoul.GUI.Auth
{
    class Program
    {
        [Variable] public static int test = 50;
        [Variable] public static int[] test2 = new[] { 25, 46 };
        static void Main(string[] args)
        {
            var server = new AuthServer("127.0.0.1", 5555);
            server.Initialize(typeof(Program).GetTypeInfo().Assembly);
            Console.WriteLine("Press <ENTER> to quit");
            Console.ReadLine();

            server.Cancel.Cancel();
        }
    }
}