namespace ProjetoHeranca.Lanchonete
{
    public class Lanche : Prato
    {
        public Lanche(string recheio, bool duplo) : base(recheio, 30)
        {
            if(duplo){
                Adicional = true;
                Valor = Valor + (Valor / 2);
            }
        }
    }
}