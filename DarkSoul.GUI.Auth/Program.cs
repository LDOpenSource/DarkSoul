using DarkSoul.Network.Extension;
using System;
using System.Reflection;

namespace DarkSoul.GUI.Auth
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new AuthServer();
            server.Initialize(typeof(Program).GetTypeInfo().Assembly);

            Console.WriteLine("Dark Soul Initialized, Write EXIT to quit");

            Console.In.ToLineObservable()
                .Subscribe(
                    line =>
                    {
                        switch (line)
                        {
                            case "EXIT":
                                server.Cancel.Cancel();
                                Environment.Exit(0);
                                break;
                            case "help":
                                Console.WriteLine("Write EXIT to exit the console");
                                break;
                            default:
                                Console.WriteLine("Wrong command, try 'help' to see the command list");
                                break;
                        }
                    },
                    error => Console.WriteLine("Error: " + error.Message),
                    () => Console.WriteLine("OnCompleted: LineReader"));            
        }
    }
}