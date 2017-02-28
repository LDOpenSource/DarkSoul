using System;
using System.Reflection;

namespace DarkSoul.GUI.Auth
{
    class Program
    {
        static void Main(string[] args)
        {

            var server = new AuthServer("127.0.0.1", 5555);
            server.Initialize(typeof(Program).GetTypeInfo().Assembly);



            //Console.WriteLine("Dark Soul Initialized, Press <ENTER> to quit");
            Console.ReadLine();

            server.Cancel.Cancel();
        }
    }
}