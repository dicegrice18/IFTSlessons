using Polimorfismo.Interfaces;
using System;
using System.Linq;

namespace Polimorfismo
{
    public class EUCountry : ONUCountry, IEuropeanUnion
    {
        public static int Popolazione = 0;
        // UE Contracts
        public void HumanRights() { }
        public void ConstitutionIntegration()
        {
            Constitution += "EU Costitution";
            Console.WriteLine($"{Name} -  {Constitution}");
        }

        public EUCountry(string Name, string State, string Government, string Constitution, int popolazione) :
            base(Name, State, Government, Constitution, popolazione)
        {
            Popolazione =+ popolazione;
            ConstitutionIntegration();
        }

        public void PermessoDiSoggiorno()
        {
            Console.WriteLine($"Activate residency permit for {Name}");
        }




        // ONU Contracts
        public virtual void PopulationControl()
        {


            Console.WriteLine("Polizia di Frontiera");
            Console.WriteLine("--------------------------------");

        }
        public virtual void TerritoryControl()
        {

            Console.WriteLine("ARMY");
            Console.WriteLine("--------------------------------");

        }
    }

}

