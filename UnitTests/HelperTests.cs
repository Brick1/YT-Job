using YoutubeDownloader.Youtube.Models;
using static System.Net.WebRequestMethods;

namespace UnitTests
{
    public class Tests
    {

        YoutubeManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new YoutubeManager();
        }

        [Test]
        public void ValidateTitleTest()
        {
            string[] titles = {
                "\r\n          Arcane | TEETH [Edit/Tribute]!\r\n        ",
                "\r\n          Unlike Pluto - Revenge, And A Little More\r\n        ",
                "\r\n          twenty one pilots - My Blood (Official Video)\r\n        ",
                "\r\n          VINAI x Le Pedre - I Was Made (Official Lyric Video)\r\n        ",
                "start*sign"

            };

            string[] excepted =
            {
                 "Arcane  TEETH EditTribute!",
                "Unlike Pluto - Revenge, And A Little More",
                "twenty one pilots - My Blood",
                "VINAI x Le Pedre - I Was Made",
                "startsign"
            };

            for (int i = 0; i < titles.Length; i++)
            {
                string title = titles[i];
                string actual = Helper.ValidateTitle(title);
                Assert.That(actual, Is.EqualTo(excepted[i]));
            }
        }

        [Test]
        public void TestExtractionFromUrl()
        {
            List<Tuple<string, string, string>> tuples = new List<Tuple<string, string, string>>
            {
              new Tuple<string, string, string> ( "https://www.youtube.com/playlist?list=PLnPE367qhYpB8sfyp7UJxY6VJpd0BsFnX","PLnPE367qhYpB8sfyp7UJxY6VJpd0BsFnX","" ),
              new Tuple<string, string, string> ( "https://www.youtube.com/watch?v=wh_qyX6D9wM&list=PLnPE367qhYpB8sfyp7UJxY6VJpd0BsFnX&index=1","PLnPE367qhYpB8sfyp7UJxY6VJpd0BsFnX","wh_qyX6D9wM" ),
              new Tuple<string, string, string> ( "https://www.youtube.com/watch?v=wh_qyX6D9wM","","wh_qyX6D9wM" )
            };

            foreach (var item in tuples)
            {
                string url = item.Item1;
                string actualPlaylistID = Helper.ExtractPlaylistID(url);
                string actualVideoID = Helper.ExtractVideoID(url);

                Assert.That(actualPlaylistID, Is.EqualTo(item.Item2));
                Assert.That(actualVideoID, Is.EqualTo(item.Item3));
            }
        }
    }
}