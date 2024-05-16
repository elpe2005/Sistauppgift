using System.IO;



namespace Sistauppgift
{
    public class Sparklass
    {
        StreamWriter sw = new StreamWriter("Projektbattles.txt", true);
        public void Skrivare()
        {
            sw.WriteLine("d");
            sw.Close();
        }
    }
}