using DarkSoul.Core.Instance;
using System;
using System.Collections.Concurrent;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

//http://stackoverflow.com/questions/15773008/reactive-framework-as-message-queue-using-blockingcollection
namespace DarkSoul.GUI.Auth.Manager
{
    public class AuthQueueManager : Singleton<AuthQueueManager>
    {
        BlockingCollection<AuthClient> myQueue;

        public AuthQueueManager()
        {
            myQueue = new BlockingCollection<AuthClient>();
            {
                var ob = myQueue.
                  GetConsumingEnumerable().
                  ToObservable(TaskPoolScheduler.Default);

                ob.Where(x => true /*check if it's already session on the queue*/)
                .Synchronize()
                .Subscribe(p =>
                {
                    // This handler will get called whenever 
                    // anything appears on myQueue in the future.
                    Console.Write("Consuming: {0}\n", p);
                });
            }
        }

        public bool AddClient(AuthClient client)
        {
            if (myQueue.TryAdd(client))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
