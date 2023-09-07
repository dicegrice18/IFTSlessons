﻿using Polimorfismo.Interfaces;

namespace Polimorfismo
{
    public class ONUCountry : Country, IONU
    {
        public void PopulationControl() { }
        public void TerritoryControl() { }
        public ONUCountry(string Name, string State, string Government, string Constitution, int popolazione) :
           base(Name, State, Government, Constitution)
        {
           
        }
    }
} 

    