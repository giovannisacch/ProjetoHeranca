namespace ProjetoHeranca.Escola
{
    public class Professor : Pessoa
    {
        public string Disciplina { get; }
         public Professor(string nome, DateTime dataNascimento, string cpf, string disciplina) : base(nome, dataNascimento, cpf)
        {
            Disciplina = disciplina;
        }
    }
}