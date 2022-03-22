namespace ProjetoHeranca.LojaVirtual
{
    public class VideoGame : Produto
    {
        public int QuantidadeDeJogos{get;set;}
        public VideoGame() : base(1500, 7){

        }

        public void AdicionarJogos(int quantidadeDeJogos){
            QuantidadeDeJogos = quantidadeDeJogos;
            Valor = Valor + (30*quantidadeDeJogos);
        }
    }
}