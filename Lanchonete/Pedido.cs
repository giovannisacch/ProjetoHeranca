namespace ProjetoHeranca.Lanchonete
{
    public class Pedido
    {
        public string NomeDoCliente {get;set;}
        public Prato[] Pratos {get;set;}
        protected double Valor {get;set;}
        public Pedido(string nomeDoCLiente, Prato[] pratos)
        {
            NomeDoCliente = nomeDoCLiente;
            Pratos = pratos;
        }
        public double CalcularValor(){
            double valor = 0; 
            for(var contador = 0;contador < Pratos.Length; contador++){
                valor = valor + Pratos[contador].CalcularPreco();
            }
            Valor = valor;
            return valor;
        }
        public double RealizarPagamento(double valorPago){
           if(valorPago >= Valor)
           {
                return valorPago - Valor;
           }else{
               return -1;
           }
        } 

    }
}