using Polimorfismo.Interfaces;
using System;

namespace Polimorfismo
{

    public class EuroZoneCountry : EUCountry, IEuroZone
    {
        // ONU Contracts
        // EURO Contracts
        // EU Contracts 

        public EuroZoneCountry(string Name, string State, string Government, string Constitution, int popolazione)
            : base(Name, State, Government, Constitution, popolazione)
        {

        }


        public void Euro()
        {
            //Contratto EURO ZONA 
        }
    }



}

