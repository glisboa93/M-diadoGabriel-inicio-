// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
//tipo de dado + nome da variável  (sintaxe)
int n1, n2, n3, media;
//entrada de dados
Console.WriteLine("Digite a primeira nota: ");
n1= int.Parse(Console.ReadLine());
Console.ReadKey();
Console.WriteLine("Digite a segunda nota: ");
n2= int.Parse(Console.ReadLine());
Console.ReadKey();
Console.WriteLine("Digite a terceira nota: ");
n3= int.Parse(Console.ReadLine());
Console.ReadKey();

// processamento
media= (n1 + n2 + n3) /3;
Console.WriteLine("A média é: " + media);

