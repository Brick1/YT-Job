Youtube Downloader
==================

My personal project for my personal growth in programming. In this file i will try to explain some of the core function of the project.

Basic thought
=============

Well, I've tried multiple directions in this project. The focus was on the Youtbemanager class, which should provide basic operations on the playlists and videos so it can easily manipulative across the app. That's why I created a seperate project for different use cases. 

Projects
=========
Core library
As the first project I would like to mention the YoutubeDownloaderLib. It's a core library for the whole app. It has model classes like a YoutbedownloaderManager, which happens to be basic class for work with the library. It loads API key from a JSON file in the %appdata% program's folder. Uses hepler classes like MediaConverter for multimedia convertions and uses third-party library for downloading videos from the YT. This core project also has interfaces for work with the Youtube's native models.
In this project I've ran into multiple problems like deprecitated third-party libraries, ...
To be continued...
