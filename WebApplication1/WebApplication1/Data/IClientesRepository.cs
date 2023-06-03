namespace WebApplication1.Data
{
    public interface IClientesRepository
    {
        IEnumerable<string> ObterTodos();
    }

    public class ClientesListRepository : IClientesRepository
    {
        public ClientesListRepository()
        {
        }

        public IEnumerable<string> ObterTodos()
        {
            return new List<string>
            {
                "Michel Banagouro",
                "Matehus Trindade",
                "Fabio Castro"
            };
        }
    }

    public class ClientesMongoDBRepository : IClientesRepository
    {
        public IEnumerable<string> ObterTodos()
        {
            return new List<string>
            {
                "Michel Banagouro (MongoDB)",
                "Matehus Trindade (MongoDB)",
                "Fabio Castro (MongoDB)"
            };
        }
    }
}
