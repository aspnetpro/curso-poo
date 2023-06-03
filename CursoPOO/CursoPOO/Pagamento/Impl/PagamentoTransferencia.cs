namespace CursoPOO.Pagamento.Impl;

public class PagamentoTransferencia
{
    public void Pagar(decimal total)
    {
        Console.WriteLine($"Realizando a transferencia da cesta no valor total de: {total.ToString("C")}");
        Console.WriteLine("Transferencia realizada com sucesso!");
    }
}
