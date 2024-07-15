using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    public class MediaConverter
    {
        private static readonly string ffmpegPath = Path.Combine(Environment.CurrentDirectory, "ffmpeg.exe");

        /// <summary>
        /// Converts media file based on input path and output path
        /// </summary>
        /// <param name="inputPath">Full path of the input file</param>
        /// <param name="outputPath">Full path of the output file</param>
        public static async Task ConvertAsync(string inputPath, string outputPath, CancellationToken token)
        {
            string arguments = $"-i \"{inputPath}\" \"{outputPath}\"";
            await ExecuteFFmpegCommand(arguments);
        }

        public static async Task<string> ExecuteFFmpegCommand(string arguments)
        {
            var tcs = new TaskCompletionSource<string>();

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.OutputDataReceived += (sender, e) =>
            {
                if (e.Data == null)
                {
                    tcs.TrySetResult("None data");
                }
                else
                {
                    tcs.TrySetResult(e.Data);
                    Console.WriteLine(e.Data);
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (e.Data == null)
                {
                    tcs.TrySetResult("None data");
                }
                else
                {
                    tcs.TrySetResult("ERROR: " + e.Data);
                    Console.WriteLine(e.Data);
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await Task.Run(() => process.WaitForExit());
            return await tcs.Task;
        }
    }
}
