using System;
using System.Collections.Generic;

namespace MediaPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();


            

            Console.WriteLine("Per ascoltare un brano premi 'M', per guardare un film premi 'V': ");
            string MediaSelect = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            if (MediaSelect.ToUpper() == "M")
            {
                MediaPlayer song1 = new Music("LALA", "Myke Towers");
                MediaPlayer song2 = new Music("I KNOW?", "Travis Scott");
                MediaPlayer song3 = new Music("NANANA", "Peggy Gou");
                MediaPlayer song4 = new Music("RELAX MY EYES", "Anotr");
                player.Add(song1);
                player.Add(song2);
                player.Add(song3);
                player.Add(song4);
                player.Print();

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Seleziona la canzone desiderata: ");
                int SongSelect = Convert.ToInt32(Console.ReadLine());

                player.Play(SongSelect);
                while (true)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("(Press N) -  Next Song");
                    Console.WriteLine("(Press B) -  Previous Song");
                    Console.WriteLine("(Press P) -  Pause");
                    Console.WriteLine("(Press E) -  Exit");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "P":
                            player.Pause();
                            break;

                        case "N":
                            player.Next();
                            break;

                        case "B":
                            player.Previous();
                            break;

                        case "E":
                            player.Exit(0);
                            break;

                        default:
                            Console.WriteLine("");
                            break;

                    }

                }
            }
            else if (MediaSelect.ToUpper() == "V")
            {
                MediaPlayer film1 = new Film("John Wick 4", "Chad Stahelski");
                MediaPlayer film2 = new Film("Oppenheimer", "Christopher Nolan");
                MediaPlayer film3 = new Film("Iron Man", "Jon Favreau");
                MediaPlayer film4 = new Film("Guardiani della Galassia", "James Gunn");
                player.Add(film1);
                player.Add(film2);
                player.Add(film3);
                player.Add(film4);
                player.Print();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Seleziona il Film Desiderato: ");

                int FilmSelect = Convert.ToInt32(Console.ReadLine());
                player.Play(FilmSelect);

                while (true)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("(Press N) -  Next Film");
                    Console.WriteLine("(Press B) -  Previous Song");
                    Console.WriteLine("(Press P) -  Pause");
                    Console.WriteLine("(Press E) -  Exit");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "P":
                            player.Pause();
                            break;

                        case "N":
                            player.Next();
                            break;

                        case "B":
                            player.Previous();
                            break;

                        case "E":
                            player.Exit(0);
                            break;

                        default:
                            Console.WriteLine("");
                            break;

                    }



                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Carattere non valido, Riprova!");
                Console.ResetColor();

            }

        }

    }


            


        
}
