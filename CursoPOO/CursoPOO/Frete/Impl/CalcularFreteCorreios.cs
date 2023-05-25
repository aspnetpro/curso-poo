namespace CursoPOO.Frete.Impl;

public abstract class CalcularFreteCorreios : ICalcularFrete
{
    public abstract string Nome();
    public abstract decimal Valor();
    public abstract int Prazo();

    public virtual OpcaoFrete Calcular(Cesta cesta)
    {
        var nomeServico = Nome();
        if (String.IsNullOrWhiteSpace(nomeServico))
        {
            return null;
        }

        return new OpcaoFrete(Nome(), Valor(), Prazo());
    }
}
