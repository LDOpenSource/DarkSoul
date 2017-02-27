# DarkSoul
A public Dofus Emulator in C# (.net standard)

# Introduction
DarkSoul is a Dofus emulator implemented on c# with reactive sockets, is created for the purpose of practice the c# language and share with spanish community a good base emulator.

# Requirements for build

- Visual Studio 2017 (c# 7.0 synthax)

# Libraries used

- Reactive Extensions
- .Net Standard

# Solution Guide
### Core
All core stuff IO (readers/writers), reflection, injection extensions
### GUI
Auth/World GUI (console) in .netcore (multiplatform support), handle of packets, server init
### Network
All Network base stuff, reactive sockets, message handler/builder
### Network.IPC
All code it's from ASP.Net Core Hubs, edited to make compatible with Net Standard with reactive sockets

# Usefull resources
The solution contains a resources.txt file that contains usefull c# research links

# Credits
Reactive Socket by JetBlack [link to Repo!](https://github.com/rob-blackbourn/JetBlack.Network)
SignalR by Microsft [link to Repo!](https://github.com/aspnet/SignalR)
Other credits to page resources authors on resources.txt
