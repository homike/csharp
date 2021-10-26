using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class AsyncSample 
    {
        public static void Run() 
        {
            callMethod();

            var context = SynchronizationContext.Current;
            if (context == null) {
                Console.WriteLine("context is null");
            }
            Console.WriteLine("=====Main END====={0}, context: {1}", ThreadID(), context);

            Console.ReadKey();
        }

        public static async void callMethod()
        {
            Task<int> task = Method1();
            Method2();

            Console.WriteLine("=====before await===== {0}", ThreadID());

            int count = await task;
            Method3(count);

            Console.WriteLine("=====after await===== {0}", ThreadID());
        }

 		public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
               for (int i = 0; i < 100; i++)
               {
               count += 1;
               }
               Console.WriteLine("=====async Method1 END===== {0}", ThreadID());
            });

            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                //Console.WriteLine("Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        static string ThreadID()
        {
            return String.Format("ThreadID[{0}]", Thread.CurrentThread.ManagedThreadId.ToString());
        }
    }
}
