namespace Heranças_de_Classes.Classes
{
    public class PessoaJuridica:Pessoas
    {
        public string cnpj;
        public string inscricaoEstadual;


        public bool Verificar1(string aa){
            if (aa!="")
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}