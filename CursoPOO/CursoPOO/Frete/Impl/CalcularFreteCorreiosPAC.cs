namespace CursoPOO.Frete.Impl;

public sealed class CalcularFreteCorreiosPAC : CalcularFreteCorreios
{
    public override string Nome()
    {
        return "PAC";
    }

    public override int Prazo()
    {
        return 10;
    }

    public override decimal Valor()
    {
        return 15M;
    }

    //public override OpcaoFrete Calcular(Cesta cesta)
    //{
    //    return base.Calcular(cesta);
    //}
}
