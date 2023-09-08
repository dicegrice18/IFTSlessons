using System;
using System.Collections.Generic;

namespace GestioneUniversita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Universita> universitaDict = new Dictionary<int, Universita>();
            Dictionary<int, Corso> corsoDict = new Dictionary<int, Corso>();
            Dictionary<int, Matricola> matricolaDict = new Dictionary<int, Matricola>();
            Dictionary<int, Esame> esameDict = new Dictionary<int, Esame>();
            Dictionary<int, Voto> votoDict = new Dictionary<int, Voto>();

            Universita universita = new Universita("Università Bocconi");
            universitaDict.Add(1, universita);

            Corso informatica = new Corso("Informatica");
            Corso matematica = new Corso("Matematica");
            corsoDict.Add(1, informatica);
            corsoDict.Add(2, matematica);

            Matricola davide = new Matricola(1001, "Davide Melia");
            Matricola carlos = new Matricola(1002, "Carlos Sainz");
            matricolaDict.Add(1, davide);
            matricolaDict.Add(2, carlos);

            universita.Corsi.Add(1, informatica);
            universita.Corsi.Add(2, matematica);

            informatica.Matricole.Add(1, davide);
            matematica.Matricole.Add(2, carlos);

            Esame esame1 = new Esame("Programmazione C#", informatica);
            Esame esame2 = new Esame("Calcolo I", matematica);
            esameDict.Add(1, esame1);
            esameDict.Add(2, esame2);

            Voto voto1 = new Voto(27, esame1);
            Voto voto2 = new Voto(19, esame2);
            votoDict.Add(1, voto1);
            votoDict.Add(2, voto2);

            esame1.VotoAssociato = voto1;
            esame2.VotoAssociato = voto2;

            davide.Esami.Add(1, esame1);
            carlos.Esami.Add(2, esame2);

            // Esempio di accesso ai dati tramite le relazioni
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Informazioni su Davide Melia:\n");
            Console.ResetColor();
            Console.WriteLine("Nome: " + davide.NomeStudente);
            Console.WriteLine("Università: " + universitaDict[1].Nome);
            Console.WriteLine("Corsi:");
            foreach (var corso in davide.Esami.Values)
            {
                Console.WriteLine("- Corso: " + corso.CorsoAssociato.Nome);
                Console.WriteLine("  Esame: " + corso.Nome);
                Console.WriteLine("  Voto: " + corso.VotoAssociato.Valore);
            }

            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Informazioni su Carlos Sainz:\n");
            Console.ResetColor();
            Console.WriteLine("Nome: " + carlos.NomeStudente);
            Console.WriteLine("Università: " + universitaDict[1].Nome);
            Console.WriteLine("Corsi:");
            foreach (var corso in carlos.Esami.Values)
            {
                Console.WriteLine("- Corso: " + corso.CorsoAssociato.Nome);
                Console.WriteLine("  Esame: " + corso.Nome);
                Console.WriteLine("  Voto: " + corso.VotoAssociato.Valore);
            }
        }
    }
}
