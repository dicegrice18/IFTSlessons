using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class Player
    {
        public List<MediaPlayer> Playlist = new List<MediaPlayer>();
        private MediaPlayer CurrentMedia = null;
        public int index;

        
        public void Print() 
        {
            int tmp = 0;
            
            Console.WriteLine("Lista:");
            foreach (var media in Playlist)
            {
                tmp = tmp + 1;
                Console.Write((tmp) + "-");
                
                media.Print();
            }
        }
        public  void Add(MediaPlayer mediaPlayer) 
        {
            this.Playlist.Add(mediaPlayer);
        }

        public void Play(int choice)
        {
            this.index = choice - 1;
            CurrentMedia = Playlist[choice - 1];
            string title = CurrentMedia.Title;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ora in riproduzione: " + title);
            Console.ResetColor();

        }

        public void Pause() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ora in Pausa: " + CurrentMedia.Title);
            Console.ResetColor();
        }
        public void Next() 
        {
            this.index = index +1;
            if (index >= 0 && index < Playlist.Count) 
            {  
                this.CurrentMedia = Playlist[index];
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ora in riproduzione: " + CurrentMedia.Title);
                Console.ResetColor();

            }
            else
            {
                CurrentMedia = Playlist.First();
                this.index = 0;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ora in riproduzione: " + CurrentMedia.Title);
                Console.ResetColor();
            }
        }
        public void Previous() 
        {
            this.index = index - 1;
            if (index >= 0 && index < Playlist.Count)
            {
                this.CurrentMedia = Playlist[index];
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ora in riproduzione: " + CurrentMedia.Title);
                Console.ResetColor();

            }
            else
            {
                CurrentMedia = Playlist.Last();
                this.index = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ora in riproduzione: " + CurrentMedia.Title);
                Console.ResetColor();
            }
        }
        public void Exit(int exitCode)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chiusura Applicazione.");
            Environment.Exit(exitCode);
            Console.ResetColor();
        }


    }
}
