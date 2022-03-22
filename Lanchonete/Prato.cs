namespace ProjetoHeranca.Lanchonete
{
    public class Prato
    {
        public string Recheio {get;set;}
        public double Valor {get;set;}
        protected bool Adicional {get;set;}

        public Prato(string recheio, double valor)
        {
            Recheio = recheio;
            Valor = valor;
        }

        public virtual double CalcularPreco(){
            return Valor;
        }
    }
}