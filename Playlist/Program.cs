using System;
using System.Collections.Generic;

namespace Playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Makes an instance of playlist and create 3 tracks
            Playlist playlist = new Playlist("Rock");
            LinkedListNode<Track> t1 = new LinkedListNode<Track>(new Track("Boulevard of broken dreams", 131, "Jesus of Suburbia", "Green Day"));
            LinkedListNode<Track> t2 = new LinkedListNode<Track>(new Track("Ghost Division", 141, "Heroes", "Sabaton"));
            LinkedListNode<Track> t3 = new LinkedListNode<Track>(new Track("Seven pillars of wisdom", 121, "The war to end all wars", "Sabaton"));

            // adds 3 tracks to the playlist
            playlist.Tracks.AddFirst(t1);
            playlist.Tracks.AddLast(t2);
            playlist.Tracks.AddAfter(t1, t3);


            Console.WriteLine(playlist.ToString());

            Console.ReadKey();


        }
    }
}
