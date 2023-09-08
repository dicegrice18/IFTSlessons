using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneUniversita
{
    public class Matricola
    {
        public int ID;
        public string NomeStudente;
        public Dictionary<int, Esame> Esami;

        public Matricola(int id, string nomeStudente)
        {
            ID = id;
            NomeStudente = nomeStudente;
            Esami = new Dictionary<int, Esame>();
        }
    }
}
