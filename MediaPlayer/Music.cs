using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal class Music : MediaPlayer
    {
        public string Autor;

        public Music(String title, string autor) : base(title)
        {
            Autor = autor;
        }
        public override void Print() {
            
            Console.WriteLine($"Titolo: {base.Title},{(this.Autor)}");
        }
    }
}
