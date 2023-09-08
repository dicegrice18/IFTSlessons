using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneUniversita
{
    public class Corso
    {
        public string Nome;
        public Dictionary<int, Matricola> Matricole;

        public Corso(string nome)
        {
            Nome = nome;
            Matricole = new Dictionary<int, Matricola>();
        }
    }
}
