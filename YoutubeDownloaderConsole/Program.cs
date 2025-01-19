using YoutubeDownloader.Youtube;
using YoutubeDownloader.Youtube.Interfaces;
using YoutubeDownloader.Youtube.Models;

namespace YoutubeDownloaderConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubeManager manager = new YoutubeManager();
            IProgress<double> progress = new Progress<double>();
            manager.DownloadVideoAsync("https://www.youtube.com/watch?v=oqCY1Hxd8FU", progress).Wait();

            
            
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}