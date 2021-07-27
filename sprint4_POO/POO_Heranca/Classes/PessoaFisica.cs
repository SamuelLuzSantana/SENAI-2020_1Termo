namespace Heranças_de_Classes.Classes
{
    public class PessoaFisica:Pessoas
    {
        public string rg;
        public string cpf;

        public bool Verificar(string aa){
            if (aa.Length<8)
            {
                return true;
            }
            else{
                return false;
            }
        }


    }
}