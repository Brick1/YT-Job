Youtube Downloader
==================

My personal project for my personal growth in programming. In this file i will try to explain some of the core function of the project.

Basic thought
=============

Well, I've tried multiple directions in this project. The focus was on the Youtbemanager class, which should provide basic operations on the playlists and videos so it can easily manipulative across the app. That's why I created a seperate project for different use cases. 

Projects
=========
Core library
-------------
As the first project I would like to mention the YoutubeDownloaderLib. It's a core library for the whole app. It has model classes like a YoutbedownloaderManager, which happens to be basic class for work with the library. It loads API key from a JSON file in the %appdata% program's folder. Uses hepler classes like MediaConverter for multimedia convertions and uses third-party library for downloading videos from the YT. This core project also has interfaces for work with the Youtube's native models.
In this project I've ran into multiple problems like deprecitated third-party libraries, bad DTOs. And at first it was just one project in the whole solution, which was bad decision. Now it's standalone library, which I can use in any project I'd like to. This decision was made because, in a distant future, I'd like to use on a server with self-made apps for Android and maybe iOS. Hence it's just a learning project it doesn't get the time it deservers.

WPF Project
-----------
The second thing I'd like to mention is Windows Presenation Framework. I've been using it since my early days with C#, so I'm pretty familiar. In these days I'd like to use some new technology like React or so. This project is made entirely for UI aas it supposed to be. The main logic is hidden in Core Library. 

Console Project
---------------
The third thing I'd like to mention is the Console project that I've made just for quick testing of the third-party library and for testing a new functionality. 

Unit Tests
-----------
As a real programmer I'm trying to stay consistent in my code, but it's not always possible because I'm still learning new stuff. So I needed tests because of the changes in the Core Library. 

Any constructive criticism is welcomed.
