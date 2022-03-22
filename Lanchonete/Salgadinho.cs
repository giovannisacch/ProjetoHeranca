namespace ProjetoHeranca.Lanchonete
{
    public class Salgadinho : Prato
    {
         public Salgadinho(string recheio, bool frito) : base(recheio, 6)
        {
            if(frito){
                Adicional = true;
                Valor = Valor + 1;
            }
        }
    }
}