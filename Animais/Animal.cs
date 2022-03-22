namespace ProjetoHeranca.Animais
{
    // Todos animais tem as propriedades Raca, Idade e Peso
    // Todos animais devem Comer(Cada um deve retornar a quantidade) e TomarBanho(cada um demora um tempo)
    public class Animal
    {
        public string Raca {get;set;}
        public int Idade {get;set;}
        public double Peso{get;set;}
        public Animal()
        {
            
        }
        public Animal(string raca, int idade, double peso)
        {
            Raca = raca;
            Idade = idade;
            Peso = peso;
        }

        public virtual int TomarBanho(){
            return 20;
        }   
        public virtual int Comer(){
            return 40;
        } 
    }
}