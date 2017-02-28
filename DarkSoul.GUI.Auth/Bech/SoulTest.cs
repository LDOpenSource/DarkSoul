using DarkSoul.GUI.Auth.Souls;
using DarkSoul.Network.IPC;
using System.Diagnostics;
using System.Linq;

namespace DarkSoul.GUI.Auth.Bech
{
    public class SoulTest
    {
        public SoulConnection ipcClient = new SoulConnection("127.0.0.1", 5556);
        private SoulProxy ipcCltProxy;

        public SoulTest()
        {
            ipcCltProxy = ipcClient.CreateSoulProxy();
        }

        public double SendString()
        {
            var results = new long[100];
            var timer = new Stopwatch();
            for (int i = -1; i < 100; i++)
            {
                if(i == -1)
                {
                    timer.Start();
                    //avoid not cached
                    var test = ipcCltProxy.Invoke<string>("Test", "Test String").Result;
                    timer.Stop();
                }
                else
                {
                    //timer.Reset();
                    timer.Start();
                    var test = ipcCltProxy.Invoke<string>("Test", $"Test String{i}").Result;
                    System.Console.WriteLine(test);
                    timer.Stop();

                    results[i] = timer.ElapsedMilliseconds;
                }                
            }
            return results.Sum();
        }

        public double SendUser()
        {
            var results = new long[10];
            var timer = new Stopwatch();
            for (int i = -1; i < 10; i++)
            {
                if (i == -1)
                {
                    timer.Start();
                    //avoid not cached
                    var test = ipcCltProxy.Invoke<User>("Test5", $"User{i}").Result;
                    timer.Stop();
                }
                else
                {
                    timer.Reset();
                    timer.Start();
                    var test = ipcCltProxy.Invoke<User>("Test5", $"User{i}").Result;
                    System.Console.WriteLine(test);
                    timer.Stop();

                    results[i] = timer.ElapsedMilliseconds;
                }
            }
            return results.Sum();            
        }
    }
}
