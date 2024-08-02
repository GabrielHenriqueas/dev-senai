//Crie uma classe Produto
//Com as propriedades : int Códigos, string Nome, float Preco
using ListasObjetos;

List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto (2563, "camiseta QuickSilver", 19.90f)
);

produtos.Add(
    new Produto (2563, "camiseta QuickSilver", 19.90f)
);

produtos.Add(
    new Produto (2563, "camiseta QuickSilver", 19.90f)
);

produtos.Add(
    new Produto (2563, "camiseta QuickSilver", 19.90f)
);

Produto calcaDiesel = new Produto (1526, "Calça Diesel Calvo Klien", 15f);
produtos.Add(calcaDiesel);

foreach (var item in produtos)
{
    Console.WriteLine($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} {produtos.IndexOf(item)} ");
    
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index,produtoBuscado);

Console.WriteLine($"Lista Atualizada");
Console.WriteLine($"******************");

foreach (var item in produtos)
{
    Console.WriteLine($"Codigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} {produtos.IndexOf(item)} ");
    
}


Console.WriteLine($"{produtoBuscado.Codigo}, {produtoBuscado.Nome}, {produtoBuscado.Preco}");
