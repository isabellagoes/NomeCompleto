Console.WriteLine("Insira a seguir:");
Console.WriteLine();

Console.Write("Seu nome: ");
string nome;
nome = Console.ReadLine()!;

Console.Write("Seu sobrenome: ");
string sobrenome;
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");