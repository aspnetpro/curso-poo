using CursoPOO.DesignPatterns.Estrutural;
using CursoPOO.Pagamento;
using CursoPOO.Pagamento.Impl;

namespace CursoPOO;

public class SelecionarPagamento
{
    public static IPagamento Informar()
    {
        Console.WriteLine("Informe a forma de pagamento (BOLETO|CARTAO|PIX): ");
        
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "BOLETO":
                return new PagamentoBoleto();
            case "CARTAO":
                return new PagamentoCartaoCredito();
            case "PIX":
                return new PagamentoPix();
            case "TRANSFERENCIA":
                var pagtoTransf = new PagamentoTransferencia();
                return new PagamentoTransferenciaAdapter(pagtoTransf);
            default:
                return new PagamentoNaoRealizado();
        }
    }
}
