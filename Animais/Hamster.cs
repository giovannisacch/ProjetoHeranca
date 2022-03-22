namespace ProjetoHeranca.Animais
{
    public class Hamster : Animal
    {
        public Hamster(string raca, int idade, double peso) : base(raca, idade, peso)
        {
            
        }
        public override int Comer(){
            return 25;
        }
         public override int TomarBanho(){
            return 5;
         }
    }
}