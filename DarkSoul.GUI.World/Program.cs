using DarkSoul.GUI.Auth.Souls;
using DarkSoul.Network.IPC;
using System;
using System.Diagnostics;

namespace DarkSoul.GUI.World
{
    class Program
    {
        static void Main(string[] args)
        {
            var ipcClient = new SoulConnection("127.0.0.1", 5556);
            var ipcCltProxy = ipcClient.CreateSoulProxy();

            Console.WriteLine("Soul Client init on port 5556");

            var timer = new Stopwatch();
            timer.Start();
            var result = ipcCltProxy.Invoke<string>("Test", "without Cache").Result;
            timer.Stop();

            Console.WriteLine($"Server IPC Result {result}, elapsed: {timer.ElapsedMilliseconds} ms [Without Json Cache Just First Message Sended]");

            timer.Reset();
            timer.Start();
            result = ipcCltProxy.Invoke<string>("Test", "with Cache").Result;
            timer.Stop();

            Console.WriteLine($"Server IPC Result {result}, elapsed: {timer.ElapsedMilliseconds} ms [With Json Cache]");

            timer.Reset();
            timer.Start();
            var user = ipcCltProxy.Invoke<User>("Test5", "Master").Result;
            timer.Stop();
            Console.WriteLine($"Server IPC User1 {user}, elapsed: {timer.ElapsedMilliseconds} ms");

            timer.Reset();
            timer.Start();
            user = ipcCltProxy.Invoke<User>("Test6", "Race").Result;
            timer.Stop();
            Console.WriteLine($"Server IPC User2 [On Test6] {user}, elapsed: {timer.ElapsedMilliseconds} ms");

            timer.Reset();
            timer.Start();
            user = ipcCltProxy.Invoke<User>("Test5", "Pc").Result;
            timer.Stop();
            Console.WriteLine($"Server IPC User3 {user}, elapsed: {timer.ElapsedMilliseconds} ms");

            timer.Reset();
            timer.Start();
            result = ipcCltProxy.Invoke<string>("Test3", 556568).Result;
            timer.Stop();
            Console.WriteLine($"Server IPC Result2 {result}, elapsed: {timer.ElapsedMilliseconds} ms");

            timer.Reset();
            timer.Start();
            result = ipcCltProxy.Invoke<string>("Test4", 887987).Result;
            timer.Stop();
            Console.WriteLine($"Server IPC Result3 {result}, elapsed: {timer.ElapsedMilliseconds} ms");
            
            Console.ReadLine();
        }
    }
}