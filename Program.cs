using Sistauppgift;

class Program
{
    static void Main(string[] args)
    {
        Bärsärk bärsärk = new Bärsärk();
        Spelare spelare = new Spelare();

        while (spelare.Spelaren() > 0 && bärsärk.Bärsärkfiende() > 0)
        {
            Console.WriteLine("Skriv 1 för attack.");
            Console.WriteLine("Skriv 2 för pilbågsattack.");
            Console.WriteLine("Skriv 3 för block.");
            Console.WriteLine("Skriv 4 för statistik.");

            string val = Console.ReadLine(); //Använder denna så loopen inte fortsätter i evighet, personen måste fortsätta för att uppdatera loopen.
        
            if(val == "1")
            {
                Console.Clear();
                Console.WriteLine("You attacked for 5 damage!");
                bärsärk.Bärsärkfiende();
            }
            if (val == "2")
            {
                Console.Clear();
                Console.WriteLine("Du använde din pilbåge, fienden tog 7 skada"); // måste göra if satsen så man måste vara en pilbågs gubbe för att göra denna.
                bärsärk.Bärsärkfiende();
            if (val == "3")
            {
                Console.Clear();
                Console.WriteLine("du blockar fiendens attack!");
            }
            }
            if (val == "4")
            {
                Console.Clear();
                Console.WriteLine("Spelaren har " + spelare.Spelaren() + " health.");
                Console.WriteLine("Fienden har " + bärsärk.Bärsärkfiende() + " health.");
            }
        }
    }
}