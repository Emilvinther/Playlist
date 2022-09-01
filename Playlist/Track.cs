using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    internal class Track
    {
        private string name;
        private int duration;
        private string album;
        private string artist;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private string Album
        {
            get { return album; }
            set { album = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public Track(string name, int duration, string album, string artist)
        {
          this.name = name;
          this.duration = duration;
          this.album = album;
          this.artist = artist;
        }

    }
}
