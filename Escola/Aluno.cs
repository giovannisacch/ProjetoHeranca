namespace ProjetoHeranca.Escola
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, DateTime dataNascimento, string cpf) : base(nome, dataNascimento, cpf)
        {
        }
        public Aluno(Pessoa pessoa) : base(pessoa.Nome, pessoa.DataDeNascimento, pessoa.CPF)
        {
        }
    }
}