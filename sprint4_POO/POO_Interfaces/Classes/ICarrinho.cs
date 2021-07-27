namespace Interface.Classes
{
        public interface ICarrinho 
            //CRUD
    {

            //CREATE
        void Cadastrar(Produto produto);



            //READ
        void Listar();



            //UPDATE
        void Alterar(int cod, Produto produto);



            //DELETE
        void Deletar(Produto produto);
        
            
        }
}