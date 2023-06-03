using CursoPOO.Pagamento;
using CursoPOO.Pagamento.Impl;

namespace CursoPOO.DesignPatterns.Estrutural;

public class PagamentoTransferenciaAdapter : IPagamento
{
    private PagamentoTransferencia _pagamentoTransferencia;

    public PagamentoTransferenciaAdapter(PagamentoTransferencia pagamentoTransferencia)
    {
        _pagamentoTransferencia = pagamentoTransferencia;
    }

    public void Processar(Cesta cesta)
    {
        _pagamentoTransferencia.Pagar(cesta.ValorTotal);
    }
}
