using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string nome = Console.ReadLine();

Console.WriteLine("\nQuantos quartos tem sua casa? ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("\nEntre com o preço de um produto: ");
double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("\nDigite seu último nome, idade e altura: ");
string[] vet = Console.ReadLine().Split(' ');
string ultimoNome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine("Você Digitou: \n");
Console.WriteLine($"{nome}\n");
Console.WriteLine(quartos);
Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));