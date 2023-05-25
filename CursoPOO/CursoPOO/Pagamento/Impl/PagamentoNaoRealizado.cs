namespace CursoPOO.Pagamento.Impl;

public class PagamentoNaoRealizado : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine("Pagamento não realizado!");
    }
}
