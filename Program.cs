using Sistauppgift;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Bärsärk bärsärk = new Bärsärk();
        Spelare spelare = new Spelare();
        Sparklass sparklass = new Sparklass();

        while (spelare.HP > 0 && bärsärk.HP > 0)
        {
            Console.WriteLine("Skriv 1 för attack.");
            Console.WriteLine("Skriv 2 för pilbågsattack.");
            Console.WriteLine("Skriv 3 för block.");
            Console.WriteLine("Skriv 4 för statistik.");

            string val = Console.ReadLine(); //Använder denna så loopen inte fortsätter i evighet, personen måste fortsätta för att uppdatera loopen.
            int Poäng;
            int FiendeAttack = new Random().Next(1, 11);
            int FiendeLångAttack = new Random().Next(1,15);
            int SkadaRandom = new Random().Next(1, 11);
            int SkadaLångRandom = new Random().Next(1,15);

            if(val == "1")
            {
                Console.Clear();
                bärsärk.TaHP(SkadaRandom);
                Console.WriteLine("Fienden attackerade dig, du tog " + FiendeAttack + " skada."); //Behöver hitta hur man tar bort övre hp, och hur man visar val 3 igen.
                spelare.TaHp(FiendeAttack);    
            } 
            else if(val == "2")
            {
                Console.Clear();
                bärsärk.TaHP(SkadaLångRandom);
                Console.WriteLine("Fienden attackerade dig, du tog " + FiendeLångAttack + " skada.");
                spelare.TaHp(FiendeLångAttack);
            }
             else if(val == "3")
            {
                Console.Clear();
                Console.WriteLine("Du blockade fiendens attack!");
            }
            else if(val == "4")
            {
                Console.Clear();
                Console.WriteLine("Spelaren har " + spelare.HP + " hp.");
                Console.WriteLine("Fienden har " + bärsärk.HP + " hp.");
            }
            else 
            {
                Console.WriteLine("Du kan bara skriva siffrorna mellan 1-4!");
            }
        }
            Console.Clear();
            Console.WriteLine("Spelaren har " + spelare.HP + " hp.");
            Console.WriteLine("Fienden har " + bärsärk.HP + " hp.");
            sparklass.Skrivare();
    }
}