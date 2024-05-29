using System.IO;



namespace Sistauppgift
{
    public class Sparklass
    {
        public void Skrivare(int poäng)
        {
            StreamWriter sw = new StreamWriter("Projektbattles.txt");
            sw.WriteLine(poäng.ToString());
            sw.Close(); 
        }
        public void Kalkylerare(int poäng)
        {
            int räknare = 0;
            StreamReader sr = new StreamReader("Projektbattles.txt"); 
            string lil =  sr.ReadLine();
            if(lil != null)räknare = int.Parse(lil);
            sr.Close();
            Skrivare(poäng + räknare); //Kalkyleraren räknar ut om poäng ska bli - eller +.
        }
        public void SkrivaUt()
        {
            StreamReader sr = new StreamReader("Projektbattles.txt");
            string poäng = sr.ReadToEnd();
            Console.WriteLine("Det här dina poäng " + poäng);
            sr.Close(); //Här skickar den tillbaka dina poäng så man vet hur många man har.
        }
    }
}