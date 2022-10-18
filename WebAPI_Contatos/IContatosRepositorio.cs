namespace WebAPI_Contatos
{
    public interface IContatosRepositorio
    {
        void Adicionar(Contato item);
        IEnumerable<Contato> GetTodos();
        Contato Encontrar(string chave);
        void Remover(string Id);
        void Atualizar(Contato item);
    }
}
