namespace Sistauppgift
{
    public class Bärsärk : Fiende
    {
        public override void attack(Spelare spelare)
        {
            fiendeAttack = new Random().Next(2,10);
            spelare.HP -= fiendeAttack;
            Console.WriteLine("Bärsärken attackerar dig " + fiendeAttack + ".");
        }
        public override void TaSkada(int skada)
        {
            hp -= skada;
            Console.WriteLine("Du skadade en Bärsärk för " + skada + " skada"); //Detta är om fienden blir skadad.
        }
    }
}