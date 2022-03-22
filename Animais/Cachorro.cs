namespace ProjetoHeranca.Animais
{
    public class Cachorro : Animal
    {
        public Cachorro(string raca, int idade, double peso) : base(raca, idade, peso)
        {
            
        }
        public override int Comer(){
            return 100;
        }
         public override int TomarBanho(){
            return 30;
         }
    }
}