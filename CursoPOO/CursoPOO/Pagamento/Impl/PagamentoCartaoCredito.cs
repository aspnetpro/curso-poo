namespace CursoPOO.Pagamento.Impl;

public class PagamentoCartaoCredito : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine($"Realizando o pagamento da cesta no valor total de: {cesta.ValorTotalFormatado}");
        Console.WriteLine("Pagamento com cartão de crédito realizado com sucesso!");
    }
}
