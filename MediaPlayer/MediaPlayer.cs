using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public abstract class MediaPlayer
    {
        public string Title;

        public MediaPlayer(string title)
        {
            Title = title;  
        }
        public abstract void Print();


    }
}
