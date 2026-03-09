using System;
using System.Security.Cryptography;

while (true == true)
{

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Bem Vindo ao Jogo de Adivinhação! ");
Console.WriteLine("--------------------------------------------------"); 

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine("Digite um número entre 1 e 20: ");
string chute = Console.ReadLine();

int numeroDigitado = Convert.ToInt32(chute);

if (numeroDigitado == numeroAleatorio)
{
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Parabéns! Você acertou o número!");
    Console.WriteLine("--------------------------------------------------");
    Console.ReadLine();
}

else if (numeroDigitado > numeroAleatorio)
{
        Console.WriteLine("\nO número digitado foi maior que o número secreto.\n");  
        Thread.Sleep(2000);       
}
else
{      
        Console.WriteLine("\nO número digitado foi menor que o número secreto.\n");    
        Thread.Sleep(2000);         
}
Console.WriteLine("Deseja jogar novamente? (s/n)");
string? opcaoContinuar = Console.ReadLine();

if (opcaoContinuar.ToUpper() != "S")
{
    Console.WriteLine("Encerrando o programa. Até mais...\n");
    break;
}

thread.Sleep(1000);

}