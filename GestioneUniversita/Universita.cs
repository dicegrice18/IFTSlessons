using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneUniversita
{
    public class Universita
    {
        public string Nome;
        public Dictionary<int, Corso> Corsi;

        public Universita(string nome)
        {
            Nome = nome;
            Corsi = new Dictionary<int, Corso>();
        }
    }

    
}
