namespace CursoPOO.Pagamento.Impl;

public class PagamentoBoleto : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine($"Gerando boleto da cesta no valor total de: {cesta.ValorTotalFormatado}");
        Console.WriteLine("Boleto gerado com sucesso!");
    }
}
