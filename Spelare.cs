namespace Sistauppgift
{
    public class Spelare
    {
        private int hp;
        private int skadaRandom;

        public Spelare()
        {
            hp = 100; // här är spelarens fiende.
        }
        public int HP
        {
            get { return hp; } //skickar ut den.
            set { hp = value;}
        }
        public void Skadad(int skada)
        {
            hp -= skada;
            Console.WriteLine("Fienden attackerade dig, du tog " + skada + " skada"); //Detta är om fienden blir skadad.
        }
        public void spelareattack(Fiende fiende)
        {
            skadaRandom = new Random().Next(3, 13); //Detta är det olika randoms så attackerna gör olika skada varje runda.
            fiende.TaSkada(skadaRandom);
        }
    }
}