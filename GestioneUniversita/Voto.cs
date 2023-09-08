using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneUniversita
{
    public class Voto
    {
        public double Valore;
        public Esame EsameAssociato;

        public Voto(double valore, Esame esameAssociato)
        {
            Valore = valore;
            EsameAssociato = esameAssociato;
        }
    }
}
