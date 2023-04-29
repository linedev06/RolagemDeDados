
int resultado;
int FacesDoDado;

Console.WriteLine("--- Rolagem de Dados ---\n");

Console.WriteLine("Digite a quantidade das faces do dado: ");
FacesDoDado = Convert.ToInt32(Console.ReadLine());

Random random = new Random();

resultado = random.Next(1, FacesDoDado + 1);


Console.WriteLine($"O resultado da rolagem do {FacesDoDado} é: {resultado}");