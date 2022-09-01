using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    internal class Playlist
    {
        private string playlistname;
        private LinkedList<Track> tracks;

        public string PlaylistName
        {
            get { return playlistname; }
            set { playlistname = value; }
        }

        public LinkedList<Track> Tracks
        {
            get { return tracks; }
            set { tracks = value; }
        }

        public Playlist(string playlistename)
        {
            this.playlistname = playlistename;
        }
    }
}
