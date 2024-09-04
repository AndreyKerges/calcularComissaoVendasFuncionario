double produtoVend, comissao;
string nome;

Console.WriteLine("--- Comissao de Vendas ---");

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine()!;

Console.WriteLine("Digite a quantidade de produtos vendidos: ");
produtoVend = Convert.ToDouble(Console.ReadLine());

if (produtoVend <= 250)
{
    comissao = produtoVend * 1;
    Console.WriteLine($"Com base na quantidade de produtos vendidos, sua comissão é de: {comissao}");

}
else if (produtoVend <= 500)
{
    comissao = produtoVend * 2.50;
    Console.WriteLine($"Com base na quantidade de produtos vendidos, sua comissão é de: {comissao}");
}
else
{
    comissao = produtoVend * 3;
    Console.WriteLine($"Com base na quantidade de produtos vendidos, sua comissão é de: {comissao}");
}
