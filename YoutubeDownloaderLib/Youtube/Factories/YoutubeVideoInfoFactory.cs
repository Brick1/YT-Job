using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeDownloader.Youtube;
using YoutubeDownloader.Youtube.Interfaces;

namespace YoutubeDownloaderLib.Youtube.Factories
{
    internal class YoutubeVideoInfoFactory
    {

        /// <summary>
        /// Factory method for YoutubeVideoInfo
        /// </summary>
        /// <param name="itemSnippetResourceIDKind">Resource kind ID</param>
        /// <param name="itemSnippetTitle">Title of the video</param>
        /// <param name="itemSnippetAuthor">Author of the video</param>
        /// <param name="itemSnippetThumbnails">Thumbnails of the video</param>
        /// <param name="itemSnippetAddedToPlaylist">Datetime when the video was added</param>
        /// <returns><see cref="IYoutubeVideoInfo" interface/></returns>
        public static IYoutubeVideoInfo CreateYoutubeVideoInfo(string itemSnippetResourceIDKind, 
            string itemSnippetTitle, 
            string itemSnippetAuthor, 
            Thumbnails? itemSnippetThumbnails, 
            DateTime? itemSnippetAddedToPlaylist)
        {
            return new YoutubeVideoInfo
                (
                itemSnippetTitle, 
                itemSnippetAuthor, 
                itemSnippetResourceIDKind, 
                itemSnippetThumbnails, 
                itemSnippetAddedToPlaylist
                );
        }
    }
}
