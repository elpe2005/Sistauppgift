using Sistauppgift;
using System.IO;

Spelare spelare = new Spelare();
Sparklass sparklass = new Sparklass();
List<Fiende> fiender = new List<Fiende>();
fiender.Add(new Bärsärk());
fiender.Add(new Mus());

while (true) //Detta är loopen som innehåller menyn.
{
    Console.WriteLine("Skriv 1 för attack.");
    Console.WriteLine("Skriv 2 för block.");
    Console.WriteLine("Skriv 3 för statistik."); //Här är menyns val så man väljer mellan 1-4.

    string val = Console.ReadLine(); //Använder denna så loopen inte fortsätter i evighet, personen måste fortsätta för att uppdatera loopen.
    
    if(val == "1")
    {
        foreach(Fiende fiende in fiender)
        {
            spelare.spelareattack(fiende);
        }
        foreach(Fiende fiende in fiender)
        {
            fiende.attack(spelare);
        }
    } 
    else if(val == "2")
    {
        Console.Clear();
        Console.WriteLine("Du blockade fiendens attack!"); //Om man väljer denna så blockar man attacken.
    }
    else if(val == "3")
    {
        Console.Clear();
        Console.WriteLine("Spelaren har " + spelare.HP + " hp.");
        // här är information om bådas hp.
        foreach(Fiende fiende in fiender)
        {
            if(fiende is Bärsärk)
            {
                Console.WriteLine("Bärsärken har " + fiende.HP + " hp.");
            }
            if(fiende is Mus)
            {
                Console.WriteLine("Musen har " + fiende.HP + " hp.");
            }
        }
            
    }
    else 
    {
        Console.WriteLine("Du kan bara skriva siffrorna mellan 1-3!"); //Detta är så de bara kan skriva 1-3
    }
    for(int i = 0; i < fiender.Count; i++)
    {
        if(fiender[i].HP <= 0)
        {
            fiender.Remove(fiender[i]);
        }
    }
    if(fiender.Count <= 0)
    {
        break;
    }
    if(spelare.HP <= 0)
    {
        break;
    }
}

if(spelare.HP <= 0)
{
    sparklass.Kalkylerare(-1);
}
if(fiender.Count <= 0)
{
    sparklass.Kalkylerare(1);
}
sparklass.SkrivaUt();
Console.WriteLine("Spelaren har " + spelare.HP + " hp."); //Detta är så att den skriver + eller - för spelarens poäng.