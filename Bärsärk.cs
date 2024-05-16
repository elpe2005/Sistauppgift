namespace Sistauppgift
{
    public class Bärsärk
    {
        private int hp;
        public Bärsärk()
        {
            this.hp = 100;
        }
        public void TaHP(int Skada)
        {
            hp -= Skada;
            Console.WriteLine("Du skadade en fiende för " + Skada + " skada");
        }
        public int HP
        {
            get { return hp; }
        }
    }
}