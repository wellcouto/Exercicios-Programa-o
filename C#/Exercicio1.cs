using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

Console.WriteLine("Digite sua Idade:");
var idade = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Digite seu gênero M ou F:");
var genero = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite seu codigo de 4 dígitos:");
var codigo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digite o preço do {produto1}");
var preco1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Digite o preço do {produto2}");
var preco2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o numero da medida:");
var medida = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Produtos:");
Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
Console.WriteLine();
Console.WriteLine($" Registro: {idade} anos de idade, código {codigo} e gênero: {2}", idade, codigo, genero);
Console.WriteLine();
Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));