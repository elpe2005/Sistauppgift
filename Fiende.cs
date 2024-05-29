namespace Sistauppgift
{
    public class Fiende
    {
        protected int fiendeAttack;
        protected int hp;
        public Fiende()
        {
            hp = 100; //Här sätter jag hur mycket hp Bärsärken ska ha.
        }
        public virtual void TaSkada(int skada)
        {
            hp -= skada;
            Console.WriteLine("Du skadade en fiende för " + skada + " skada"); //Detta är om fienden blir skadad.
        }
        public int HP
        {
            get { return hp; } //Här skickar jag ut hp:et.
            set { hp = value; }
        }
        public int FiendeAttack
        {
            get { return fiendeAttack; } //Här är fiendensattack där i subklasserna det gör en random.
            set { fiendeAttack = value; }
        }
        public virtual void attack(Spelare spelare)
        {
            fiendeAttack = new Random().Next(1, 11); //Detta är det olika randoms så attackerna gör olika skada varje runda.
            spelare.Skadad(fiendeAttack);
        }
    }
}