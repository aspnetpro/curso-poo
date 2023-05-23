using CursoPOO;

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
    Console.WriteLine($"- {item.Nome.PadRight(35, ' ')} | Qtd {item.Quantidade} | {item.TotalFormatado}");
}
Console.WriteLine($"Total Itens da Cesta: {minhaCesta.TotalItens}");
Console.WriteLine($"Valor Total da Cesta: {minhaCesta.ValorTotal}");

// break
Console.ReadLine();