namespace Sistauppgift
{
    public class Spelare
    {
        private int hp;

        public Spelare()
        {
            this.hp = 100;
        }
        public void TaHp(int skada)
        {
            hp -= skada;
        }
        public int HP
        {
            get { return hp; }
        }
        
    }
}