// Exercício 3
// Você está desenvolvendo um sistema para uma loja virtual de eletrônicos que vende Celulares(R$500), Computadores(R$2000) e video games(R$1500)
// O Objetivo do seu sistema é realizar compras online com as seguintes regras
// Primeiro devemos Cadastrar nosso Usuário.
// Todo usuário deve ter nome e e-mail
//Esse usuário comprará produtos 
// Todo produto deve ter: o valor, quantidadeDisponivel e Marca.
// valor e quantidade devem ser definidos na criação do produto
// Video games podem ser vendidos junto a jogos, sabe-se que cada jogo custa 30 reais
// A loja virtual deve contar com um carrinho
// No carrinho você deve guardar o usuário, os produtosEscolhidos e o valorTotal da compra, por padrão nosso carrinho só poderá guardar até 5 itens.
// O Carrinho deve nascer apenas com o usuario e dentro do carrinho deve se ter o comportamento de adicionar mais itens(deve se verificar se há quantidade disponivel) e fecharCompra
//Para a criação do metódo AdicionarItem voce precisará verificar maior posição sem item do array(para nao adicionar numa posição que já tem item)
// Seu programa deve preencher as informações(dados do usuário, carrinho e produtos de acordo com o input do usuário) - vide vídeo de exemplo
using ProjetoHeranca.Animais;
using ProjetoHeranca.LojaVirtual;
namespace projetoheranca
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal[] animais = new Animal[3]; 
            animais[0] = new Cachorro("Pitbull", 3, 15);
            animais[1] = new Hamster("RacaDoHamster", 2, 2);
            animais[2] = new Gato("Siames", 2, 5);
            Pedido pedido = new Pedido("Giovanni", "11991392711", animais);
            Console.WriteLine(pedido.CalcularValor());
        }


        //Prato[] pratos = new Prato[4];
        // pratos[0] = new Pizza("Portuguesa", true); // 40
        // pratos[1] = new Lanche("X-Bacon", false); //30
        // pratos[2] = new Salgadinho("Coxinha", true); // 7
        // pratos[3] = new Salgadinho("Risoli", false); //6
        // Pedido pedido = new Pedido("Giovanni", pratos);
        // Console.WriteLine("O valor total é: " + pedido.CalcularValor());
        // Console.WriteLine("Seu troco é: " + pedido.RealizarPagamento(100));



        //  string nome, email;
        //     char minhaVariavel =  Console.ReadKey().KeyChar;
        //     nome = Console.ReadLine();
        //     Console.WriteLine("Insira seu email: ");
        //     email = Console.ReadLine();
        //     Usuario usuario = new Usuario(nome, email);
        //     Carrinho carrinho = new Carrinho(usuario);
        //     carrinho.PerguntarProdutoParaInserirNoCarrinho();
        //     Console.WriteLine("O valor total é de: " + carrinho.FecharCompra());

    }
}
