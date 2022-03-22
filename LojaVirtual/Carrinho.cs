namespace ProjetoHeranca.LojaVirtual
{
    public class Carrinho
    {
        public Usuario Usuario { get; set; }
        public Produto[] ProdutosEscolhidos { get; set; }
        public Carrinho(Usuario usuario)
        {
            Usuario = usuario;
            ProdutosEscolhidos = new Produto[5];
        }
        public void PerguntarProdutoParaInserirNoCarrinho()
        {
            bool continuar = true;

            do
            {
                int opcaoProduto, opcaoContinuar;
                bool deuCertoNoCarrinho = true;
                Console.WriteLine("Qual tipo de produto voce deseja?");
                Console.WriteLine("1- VideoGame, 2- Celular, 3- Computador");
                opcaoProduto = int.Parse(Console.ReadLine());
                switch (opcaoProduto)
                {
                    case 1:
                        VideoGame videoGame = new VideoGame();
                        int quantidadeJogos = 0;
                        Console.WriteLine("Quantos jogos deseja adicionar?");
                        quantidadeJogos = int.Parse(Console.ReadLine());
                        videoGame.AdicionarJogos(quantidadeJogos);
                        deuCertoNoCarrinho = AdicionarNovoProduto(videoGame);
                        break;
                    case 2:
                        deuCertoNoCarrinho = AdicionarNovoProduto(new Celular());
                        break;
                    case 3:
                        deuCertoNoCarrinho = AdicionarNovoProduto(new Computador());
                        break;
                    default:
                        Console.WriteLine("Não achamos a opção escolhida");
                        break;
                }
                if (!deuCertoNoCarrinho)
                {
                    Console.WriteLine("Não foi possível adicionar seu produto no carrinho");
                }
                Console.WriteLine("Quer adicionar mais itens? 1 = S | 2 = N ");
                opcaoContinuar = int.Parse(Console.ReadLine());
                if (opcaoContinuar == 1)
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            } while (continuar);
        }
        public double FecharCompra()
        {
            double valorTotal = 0;
            for (int i = 0; i < ProdutosEscolhidos.Length; i++)
            {
                if(ProdutosEscolhidos[i] != null){
                    valorTotal = valorTotal + ProdutosEscolhidos[i].Valor;
                }
            }
            return valorTotal;
        }
        public bool AdicionarNovoProduto(Produto produto)
        {
            if (produto.QuantidadeDisponivel == 0)
            {
                return false;
            }
            for (int contador = 0; contador < ProdutosEscolhidos.Length; contador++)
            {
                if (ProdutosEscolhidos[contador] == null)
                {
                    ProdutosEscolhidos[contador] = produto;
                    produto.ComprarProduto();
                    return true;
                }
            }
            return false;
        }
    }
}