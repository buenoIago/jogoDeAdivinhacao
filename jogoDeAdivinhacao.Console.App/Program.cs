using System;
//biblioteca padrão do sistema "relacionado a criptografia".
using System.Security.Cryptography;

while (true)
{

Console.WriteLine("----------------------------------------");
Console.WriteLine("Bem Vindo ao Jogo de Adivinhação! ");
Console.WriteLine("----------------------------------------");  

//Random.Shared.Next(1, 21); pode ser usado, mas o RandomNumberGenerator é mais seguro.

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine("Digite um número entre 1 e 20: ");
string chute = Console.ReadLine();

Console.WriteLine($"O valor digitado foi: {chute}");
Console.WriteLine($"O número aleatório era: {numeroAleatorio}");
Console.ReadLine();

}