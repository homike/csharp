using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    public class AwaitOperator
    {
        public static async Task Run()
        {
            Task<int> downloading = DownloadDocsMainPageAsync();
            Console.WriteLine($"{nameof(Run)}: Launched downloading." + ThreadID());

            int bytesLoaded = await downloading;
            Console.WriteLine($"{nameof(Run)}: Downloaded {bytesLoaded} bytes." + ThreadID());

        }

        private static async Task<int> DownloadDocsMainPageAsync()
        {
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: start downloading." + ThreadID());

            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading." + ThreadID());
            return content.Length;
        }

        static string ThreadID()
        {
            return String.Format("ThreadID[{0}]", Thread.CurrentThread.ManagedThreadId.ToString());
        }
    }
}
