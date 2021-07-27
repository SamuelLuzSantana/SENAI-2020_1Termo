namespace Metodos_Estáticos.Classes
{
    public static class Conversor
    {
        //Definindo a Cotação do Euro e do Dolar de forma estatica.
        public static float cotacaoDolar = 4.10f;
        public static float cotacaoEuro = 6.22f; 


        public static float valorUsuario; //Usando Valor do usuario para fazer a Conversão. 

        //Convertendo Valor do Real para DOLAR
        public static float RealDolar(){
            return valorUsuario/cotacaoDolar;
        }

        //Convertendo Valor do DOLAR para Real
        public static float DolarReal(){
            return  valorUsuario+cotacaoDolar;
        }

        //Convertendo o Valor do Real Para EURO.
        public static float RealEuro(){
            return valorUsuario/cotacaoEuro;
        }

        //Convertendo o Valor do EURO para Real.
        public static float EuroReal(){
            return valorUsuario*cotacaoEuro;
        }

        
    }
}