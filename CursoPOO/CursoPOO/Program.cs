using CursoPOO;
using CursoPOO.Frete;
using CursoPOO.Frete.Impl;
using CursoPOO.Pagamento;

//Class1 obj = new Class1();
//Console.WriteLine(obj.ToString());

// Criando uma instancia da classe Cesta
Cesta minhaCesta = new Cesta();

// Criando uma instancia da classe Item
Item bola = new Item("Bola de futebol", 89.90M, 1);
Item camiseta = new Item("Camiseta São Paulo Futebol Clube", 297.99M, 2);
Item chuteira = new Item("Chuteira Neymar", 149.99M, 1);

// Adiciona os itens na cesta
minhaCesta.AdicionarItem(bola);
minhaCesta.AdicionarItem(camiseta);
minhaCesta.AdicionarItem(chuteira);

// Imprime os valores
Console.WriteLine($"Itens da Cesta:");
foreach(Item item in minhaCesta.Itens)
{
    Console.WriteLine($"- {item}");
}
Console.WriteLine(minhaCesta);

ICalcularFrete calcularFrete = new CalcularFreteCorreiosPAC();
var opcaoFrete = calcularFrete.Calcular(minhaCesta);
if(opcaoFrete != null)
{
    Console.WriteLine($"Frete selecionado: {opcaoFrete.Nome}");
}

IPagamento pagamento = SelecionarPagamento.Informar();
pagamento.Processar(minhaCesta);

// break
Console.ReadLine();





