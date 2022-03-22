namespace ProjetoHeranca.Lanchonete
{
    public class Pizza : Prato
    {
        public Pizza(string recheio, bool bordaRecheada) : base(recheio, 30)
        {
            if(bordaRecheada){
                Adicional = true;
                Valor = Valor + 10;
            }
        }
    }
}