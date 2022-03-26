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
using ProjetoHeranca.Escola;
namespace ProjetoHeranca
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Criar classe professor
            //Aproveitar comportamentos e propriedades em comum com aluno, professor não deve herdar direto de aluno
            //Professor e aluno deverão herdar de uma mesma classe fica a seu critério definir o nome dessa classe
            //Professor além das propriedades em comum com aluno deve ter a propriedade disciplina(referente a disciplina que ele leciona)
            //Uma Sala de Aula pode ter mais de um professor
            //Você deve evoluir o metódo cadastrar novas turmas para cadastrar um mais professores na sala de aula
            var secretaria = new Secretaria();
            secretaria.CadastrarNovasTurmas();
        }


        public static void ExerciciosLista()
        {
            var nomes = new List<string>();
            var idades = new List<int>();
            var numeros = new List<int>();
            var numerosMaisDez = new List<int>();
            var strings = new List<string>();
            for (var contador = 0; contador < 10; contador++)
            {
                numeros.Add(contador + 2);
                numerosMaisDez.Add(contador + 12);
                strings.Add(contador.ToString());
            }

            //Adicionar outra lista
            numeros.AddRange(numerosMaisDez);
            //Remover Item
            // var tentativaUm = numeros.Remove(5); //Remove o valor independente da posição e devolve se removeu
            // numeros.RemoveAt(3); //Remove no indice escolhido
            // numeros.RemoveAll(numeroARemover => numeroARemover < 10 || numeroARemover > 14); //Remove todos os itens que atendam o predicado
            // numeros.RemoveRange(0, 5); //Remove itens em sequencia, parametros a primeira posição e a quantidade
            //Buscar Index
            var indexString = strings.IndexOf("Giovanni");
            var indexCinco = numeros.IndexOf(5); //Busca a posição na lista de um determinado valor
                                                 //Desafio: Fazer o IndexOf na mão utilizando vetores(arrays)
                                                 //Buscar na lista
            var valorNaPosicaoTres = numeros.ElementAt(3); //Buscar o item na posição informada
            var valorPar = numeros.Find(numero => numero % 2 == 0); //Busca o primeiro item que atenda uma posição
            var valoresParesDois = numeros.FindAll(numero => numero % 2 == 0); //Busca todos os itens que atendam uma condição 
                                                                               //Verificação
            var temQuinze = numeros.Any(numero => numero == 15);//Me confirma se existe qualquer item que atenda minha condição
            var temQuartorze = numeros.Exists(x => x == 14); //Me confirma se existe qualquer item que atenda minha condição
            var todosSaoPares = numeros.All(numero => numero % 2 == 0); //Verifica se TODOS o itens da lista atendem minha condição
            var textoComMaisDeCincoLetras = strings.All(numero => strings.Count > 5);//Verifica se TODOS o itens da lista atendem minha condição
                                                                                     //Ordenação
            var ordenadoDescendente = numeros.OrderByDescending(x => x); // Retorna uma nova lista de forma descrescente
            var ordenadoCrescente = numeros.OrderBy(x => x); // Retorna uma nova lista de forma crescente
        }


        //Animal[] animais = new Animal[3]; 
        // animais[0] = new Cachorro("Pitbull", 3, 15);
        // animais[1] = new Hamster("RacaDoHamster", 2, 2);
        // animais[2] = new Gato("Siames", 2, 5);
        // Pedido pedido = new Pedido("Giovanni", "11991392711", animais);
        // Console.WriteLine(pedido.CalcularValor());

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
