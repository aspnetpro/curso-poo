using CursoPOO.DesignPatterns.Estrutural;
using CursoPOO.Frete.Impl;
using CursoPOO.Pagamento;
using CursoPOO.Pagamento.Impl;

namespace CursoPOO;

public class SelecionarFrete
{
    public static CalcularFreteCorreios Informar()
    {
        Console.WriteLine("Informe a opção de frete (PAC|SEDEX): ");
        
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "PAC":
                return new CalcularFreteCorreiosPAC();
            case "SEDEX":
                return new CalcularFreteCorreiosSedex();
            default:
                return null;
        }
    }
}
