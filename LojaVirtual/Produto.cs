namespace ProjetoHeranca.LojaVirtual
{
    public class Produto
    {
        public double Valor {get;set;}
        public int QuantidadeDisponivel{get;set;}
        public string Marca{get;set;}

        public Produto(double valor, int quantidadeDisponivel)
        {
            Valor = valor;
            QuantidadeDisponivel = quantidadeDisponivel;
        }
        public void ComprarProduto(){
            //QuantidadeDisponivel = QuantidadeDisponivel - 1;
            QuantidadeDisponivel--;
        }
    }
}