using Sistauppgift;
using System.IO;

int poäng = 0;

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
    int fiendeAttack = new Random().Next(1, 11);
    int fiendeLångAttack = new Random().Next(1,15);
    int skadaRandom = new Random().Next(1, 11);
    int skadaLångRandom = new Random().Next(1,15);
    if(val == "1")
    {
        Console.Clear();
        bärsärk.TaHP(skadaRandom);
        Console.WriteLine("Fienden attackerade dig, du tog " + fiendeAttack + " skada."); //Behöver hitta hur man tar bort övre hp, och hur man visar val 3 igen.
        spelare.TaHp(fiendeAttack);    
    } 
    else if(val == "2")
    {
        Console.Clear();
        bärsärk.TaHP(skadaLångRandom);
        Console.WriteLine("Fienden attackerade dig, du tog " + fiendeLångAttack + " skada.");
        spelare.TaHp(fiendeLångAttack);
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
if(spelare.HP <= 0)
{
    sparklass.Kalkylerare(-1);
}
if(bärsärk.HP <= 0)
{
    sparklass.Kalkylerare(1);
}

Console.Clear();
Console.WriteLine("Spelaren har " + spelare.HP + " hp.");
Console.WriteLine("Fienden har " + bärsärk.HP + " hp.");
sparklass.Skrivare(poäng);