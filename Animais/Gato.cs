namespace ProjetoHeranca.Animais
{
    public class Gato  : Animal
    {
        public Gato(string raca, int idade, double peso) : base(raca, idade, peso)
        {
            
        }
        public override int Comer(){
            return 50;
        }
         public override int TomarBanho(){
            return 10;
         }
    }
}