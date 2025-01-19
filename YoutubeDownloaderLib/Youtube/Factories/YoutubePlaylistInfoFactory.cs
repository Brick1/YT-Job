using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeDownloader.Youtube.Interfaces;
using YoutubeDownloader.Youtube.Models;

namespace YoutubeDownloaderLib.Youtube.Factories
{
    internal class YoutubePlaylistInfoFactory
    {
        public static IYoutubePlaylistInfo GetYoutubePlaylistInfo(string? title, string? description, string? thumbnailURL, IYoutubeVideoInfo[] videoInfos)
        {
            if (string.IsNullOrEmpty(title))
                title = "Title was not provided";
            if (string.IsNullOrEmpty(description))
                description = "No description";
            if (string.IsNullOrEmpty(thumbnailURL))
                thumbnailURL = "No thumbnail";
            return new YoutubePlaylistInfo(title, description, videoInfos, thumbnailURL);
        }
    }
}
