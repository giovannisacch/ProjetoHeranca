namespace ProjetoHeranca.Animais
{
    // Crie também uma classe Pedido com as seguintes propriedades: nomeDoDono, telefoneDoDono, Animais(Vetor do tipo Animal) e preco.
// A classe Pedido devera conter um metodo contrutor que recebe nomeDoDono, telefoneDoDone e um vetor do tipo Animal e atribui o valor as propriedades
// Também deverá conter um método onde irá calcular o preço com base no tempo de banho e quantidade de ração (preço = (ração * 2) + (tempoDebanho *3))

    public class Pedido
    {
        public string NomeDoDono {get;set;}
        public string TelefoneDoDono {get;set;}
        public Animal[] Animais {get;set;}
        public Pedido(string nomeDoDono, string telefoneDODono, Animal[] animais)
        {
            NomeDoDono = nomeDoDono;
            TelefoneDoDono = telefoneDODono;
            Animais = animais;
        }

        public float CalcularValor(){
            //Animais.Length = Busca a quantidade de items que eu tenho no meu vetor
            float valorAtual = 0;
            for(var contador = 0; contador < Animais.Length; contador++){
                Animal animalAtual = Animais[contador];
                valorAtual = valorAtual + ( (animalAtual.Comer() *2) + (animalAtual.TomarBanho() * 3) );
            }
            return valorAtual;
        }

        
    }
}