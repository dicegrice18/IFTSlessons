using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal class Film : MediaPlayer
    {
        public string Director;

        public Film(string title, string director) : base(title)
        {
            Director = director;
        }
        public override void Print()
        {

            Console.WriteLine($"Titolo: {base.Title},{(this.Director)}");
        }
    }
}
