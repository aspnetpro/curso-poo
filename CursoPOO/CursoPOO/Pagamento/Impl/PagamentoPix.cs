namespace CursoPOO.Pagamento.Impl;

public class PagamentoPix : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine($"Gerando PIX da cesta no valor total de: {cesta.ValorTotalFormatado}");
        Console.WriteLine("PIX gerado com sucesso!");
    }
}
