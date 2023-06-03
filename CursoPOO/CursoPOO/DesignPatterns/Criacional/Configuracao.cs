namespace CursoPOO.DesignPatterns.Criacional;

// **********************************************************************
// Singleton https://refactoring.guru/pt-br/design-patterns/singleton
// **********************************************************************
public class Configuracao
{
    private static Configuracao _config;

    private Configuracao() { }

    public static Configuracao Instancia
    {
        get { return _config = (_config ?? new Configuracao()); }
    }

    //public static Configuracao Instancia
    //    => _config = (_config ?? new Configuracao());

    public bool LoginAtivo { get; set; }
    
    public bool CadastroOffline { get; set; }
}
