namespace Sistauppgift
{
    public class Mus : Fiende
    {
        public override void attack(Spelare spelare)
        {
            fiendeAttack = new Random().Next(1,4);
            spelare.HP -= fiendeAttack;
            Console.WriteLine("Musen attackerar dig " + fiendeAttack + "."); //Här attackerar musen först sedan skriver den ut hur mycket
        }
        public override void TaSkada(int skada)
        {
            hp -= skada;
            Console.WriteLine("Du skadade en Mus för " + skada + " skada"); //Detta är om fienden blir skadad.
        }
    }
}