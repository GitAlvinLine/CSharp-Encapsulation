using System;

namespace CSharp_Encapsulation
{

    public class CaptainAmerica
    {
        private string Name {get;} = "Captain America";
        private string Abilities {get;} = "Superhuman Strength";

        private int Age {get;} = 24;

        private string Secret {get;} = "Captain America's secret is that he wants to go back in time to see his first love.";

        public string secret
        {
            get
            {
                return Secret;
            }
        }

        public void bio()
        {
            System.Console.WriteLine("Superhero: " + Name);
            System.Console.WriteLine("Abilities: " + Abilities);
            System.Console.WriteLine("Age: " + Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CaptainAmerica cap = new CaptainAmerica();
            cap.bio();
            System.Console.WriteLine(cap.secret);

        }
    }
}
