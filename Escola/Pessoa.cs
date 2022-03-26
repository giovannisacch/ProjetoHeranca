namespace ProjetoHeranca.Escola
{
    public class Pessoa
    {
        public string CPF { get; }
        public string Nome { get; }
        public DateTime DataDeNascimento { get; }
        public Pessoa(string nome, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            DataDeNascimento = dataNascimento;
            CPF = cpf;
        }

    }
}