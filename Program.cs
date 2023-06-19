Console.Clear();

int palpite, NumSorteado, tentativas, diferenca;
string palpiteStr;

Console.ForegroundColor = ConsoleColor.Cyan;
Thread.Sleep(500); Console.WriteLine("Bem-vindo ao Jogo de Adivinha!");
Console.ResetColor();

Thread.Sleep(1000); Console.WriteLine("Antes de começarmos, irei explicar como funciona.\n");

Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Magenta;
Thread.Sleep(500); Console.WriteLine("Sortearei um número para o jogador entre 1 e 100..\n");
Thread.Sleep(500); Console.WriteLine("O jogador tem até 7 tentativas para adivinhar o número.\n");
Thread.Sleep(500); Console.WriteLine("A cada palpite errado, o jogo fornece dicas como:\n");
                    Console.ForegroundColor =  ConsoleColor.Red;
Thread.Sleep(500); Console.Write("\"Está pelando!\" ");
                    Console.ForegroundColor = ConsoleColor.White; 
Thread.Sleep(500); Console.WriteLine("se a diferença for de 3 ou menos.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
Thread.Sleep(500); Console.Write("\"Está quente!\" ");
                    Console.ForegroundColor = ConsoleColor.White;
Thread.Sleep(500); Console.WriteLine("se for de 10 ou menos.");
                    Console.ForegroundColor = ConsoleColor.Blue;
Thread.Sleep(500); Console.Write("\"Está congelando!\" ");
                    Console.ForegroundColor = ConsoleColor.White;
Thread.Sleep(500); Console.WriteLine("se for de 30 ou mais.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
Thread.Sleep(500); Console.Write("\"Frio!\" ");
                    Console.ForegroundColor = ConsoleColor.White;
Thread.Sleep(500); Console.WriteLine("nos demais casos.\n");

Thread.Sleep(500);
Console.Write("Agora que entendemos... VAMOS LÁ!\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Pressione uma tecla para iniciar o jogo...");
Console.ReadKey();

 Console.Clear();


Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Sorteei um número entre 1 e 100. Tente adivinhar!");
Console.ResetColor();

Random random = new Random();
NumSorteado = random.Next(1, 101);
tentativas = 0;

while (tentativas < 7)
{
Console.WriteLine();
Console.Write("Digite seu palpite: ");
palpiteStr = Console.ReadLine();

if (!int.TryParse(palpiteStr, out palpite) || palpite < 1 || palpite > 100)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Palpite inválido! Digite um número entre 1 e 100.");
Console.ResetColor();
continue;
}
tentativas++;

if (palpite == NumSorteado)
{
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Parabéns! Você acertou o número sorteado em " + tentativas + " tentativa(s)!");
Console.ResetColor();
return;
}

diferenca = Math.Abs(palpite - NumSorteado);

if (diferenca <= 3)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Está pelando!");
}
else if (diferenca <= 10)
{
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Está quente!");
}
else if (diferenca >= 30)
{
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Está congelando!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Está frio!");
}

if (palpite < NumSorteado)
{
Console.WriteLine("O número sorteado é maior que o palpite.");
}
else
{
Console.WriteLine("O número sorteado é menor que o palpite.");
}

Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Você excedeu o número máximo de tentativas. O número sorteado era: " + NumSorteado);
Console.ResetColor();

