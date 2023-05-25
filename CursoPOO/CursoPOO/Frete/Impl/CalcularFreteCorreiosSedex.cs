namespace CursoPOO.Frete.Impl;

public sealed class CalcularFreteCorreiosSedex : CalcularFreteCorreios
{
    public override string Nome()
    {
        return "SEDEX";
    }

    public override int Prazo()
    {
        return 2;
    }

    public override decimal Valor()
    {
        return 30M;
    }
}
