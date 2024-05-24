namespace Sistauppgift
{
    public class Bärsärk
    {
        private int hp;
        public Bärsärk()
        {
            this.hp = 100; //Här sätter jag hur mycket hp Bärsärken ska ha.
        }
        public void TaHP(int Skada)
        {
            hp -= Skada;
            Console.WriteLine("Du skadade en fiende för " + Skada + " skada"); //Detta är om fienden blir skadad.
        }
        public int HP
        {
            get { return hp; } //Här skickar jag ut hp:et.
        }
    }
}