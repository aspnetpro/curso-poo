namespace CursoPOO.Frete;

public class OpcaoFrete
{
    public string Nome { get; private set; }
    public decimal Valor { get; private set; }
    public int Prazo { get; private set; }

    private OpcaoFrete()
    {
    }

    public OpcaoFrete(string nome, decimal valor, int prazo)
    {
        Nome = nome;
        Valor = valor;
        Prazo = prazo;
    }
}