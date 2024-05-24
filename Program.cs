using Sistauppgift;
using System.IO;

Bärsärk bärsärk = new Bärsärk();
Spelare spelare = new Spelare();
Sparklass sparklass = new Sparklass();

while (spelare.HP > 0 && bärsärk.HP > 0) //Detta är loopen som innehåller menyn.
{
    Console.WriteLine("Skriv 1 för attack.");
    Console.WriteLine("Skriv 2 för pilbågsattack.");
    Console.WriteLine("Skriv 3 för block.");
    Console.WriteLine("Skriv 4 för statistik."); //Här är menyns val så man väljer mellan 1-4.

    string val = Console.ReadLine(); //Använder denna så loopen inte fortsätter i evighet, personen måste fortsätta för att uppdatera loopen.
    int fiendeAttack = new Random().Next(1, 11);
    int fiendeLångAttack = new Random().Next(1,15);
    int skadaRandom = new Random().Next(1, 11);
    int skadaLångRandom = new Random().Next(1,15); //Detta är det olika randoms så attackerna gör olika skada varje runda.
    if(val == "1")
    {


        bärsärk.TaHP(skadaRandom);
        Console.WriteLine("Fienden attackerade dig, du tog " + fiendeAttack + " skada."); //Behöver hitta hur man tar bort övre hp, och hur man visar val 3 igen.
        spelare.TaHp(fiendeAttack); //Det här koderna är så att fienden tar random skada och att fienden attackerar mig med random.
    } 
    else if(val == "2")
    {
        Console.Clear();
        bärsärk.TaHP(skadaLångRandom);
        Console.WriteLine("Fienden attackerade dig, du tog " + fiendeLångAttack + " skada.");
        spelare.TaHp(fiendeLångAttack); //Här är andra attacken så jag attackerar honom random och om han attackerar mig om han väljer två.
    }
        else if(val == "3")
    {
        Console.Clear();
        Console.WriteLine("Du blockade fiendens attack!"); //Om man väljer denna så blockar man attacken.
    }
    else if(val == "4")
    {
        Console.Clear();
        Console.WriteLine("Spelaren har " + spelare.HP + " hp.");
        Console.WriteLine("Fienden har " + bärsärk.HP + " hp."); // här är information om bådas hp.
    }
    else 
    {
        Console.WriteLine("Du kan bara skriva siffrorna mellan 1-4!"); //Detta är så de bara kan skriva 1-4
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
sparklass.SkrivaUt();
Console.WriteLine("Spelaren har " + spelare.HP + " hp.");
Console.WriteLine("Fienden har " + bärsärk.HP + " hp."); //Detta är så att den skriver + eller - för spelarens poäng.