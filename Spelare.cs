namespace Sistauppgift
{
    public class Spelare
    {
        private int hp;

        public Spelare()
        {
            this.hp = 100; // här är spelarens fiende.
        }
        public void TaHp(int skada)
        {
            hp -= skada; //koden så du kan ta hp.
        }
        public int HP
        {
            get { return hp; } //skickar ut den.
        }
        
    }
}