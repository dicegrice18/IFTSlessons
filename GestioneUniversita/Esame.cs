using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneUniversita
{
    public class Esame
    {
        public string Nome;
        public Corso CorsoAssociato;
        public Voto VotoAssociato;

    public Esame(string nome, Corso corsoAssociato)
    {
        Nome = nome;
        CorsoAssociato = corsoAssociato;
    }
    }
}
