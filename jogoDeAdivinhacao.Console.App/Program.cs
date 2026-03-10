using System;
using System.Security.Cryptography;

Console.Clear();

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Bem Vindo ao Jogo de Adivinhação! ");
Console.WriteLine("--------------------------------------------------"); 
Thread.Sleep(1000);

Console.WriteLine("Carregando o jogo...");  
Console.WriteLine("--------------------------------------------------"); 
Thread.Sleep(2000);

while (true)
{
    
    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

    System.Console.WriteLine("Iniciando uma nova rodada...\n");  
    Thread.Sleep(1000);

    Console.WriteLine("Escolha o nível de dificuldade: \n1 - Fácil (10 tentativas)\n2 - Médio (5 tentativas)\n3 - Difícil (3 tentativas)");
    
    Console.Write("Digite sua escolha: ");
    string dificuldade = Console.ReadLine();

    int numeroMaximo;
    int tentativasMaximas;

    switch (dificuldade)
    {
      case "1":
      numeroMaximo = 20;
      tentativasMaximas = 10;
      break;

      case "2":
      numeroMaximo = 50;
      tentativasMaximas = 5;
      break;

      case "3":
      numeroMaximo = 100;
      tentativasMaximas = 3;
      break;

      default:
      Console.WriteLine("--------------------------------------------------"); 
      Console.WriteLine("Selecione uma dificuldade válida.");
      Console.WriteLine("Clique ENTER para continuar...");
      Console.ReadLine();
      continue;
    }

      for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++)
      {
        Console.Clear();
        Console.WriteLine($"Tentativa {tentativa} de {tentativasMaximas}");

      Console.WriteLine($"\nDigite um número entre 1 e {numeroMaximo}: ");

      string chute = Console.ReadLine();
      int numeroDigitado = Convert.ToInt32(chute);

          if (numeroDigitado == numeroAleatorio)
          {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Parabéns! Você acertou o número!");
            Console.WriteLine("--------------------------------------------------\n");
            Thread.Sleep(2000);
            break;
          }

          else if (numeroDigitado > numeroAleatorio)
          {
          Console.WriteLine("\nO número digitado foi maior que o número secreto.\n");  
          Thread.Sleep(2500);       
          }

          else
          {      
          Console.WriteLine("\nO número digitado foi menor que o número secreto.\n");    
          Thread.Sleep(2500);         
          }

          if (tentativa == tentativasMaximas)
          {
            Console.WriteLine($"Você usou todas as suas tentivas! O número secreto era {numeroAleatorio}");
            Thread.Sleep(2000);
          }      
      }

          Console.WriteLine("--------------------------------------------------");
          Console.WriteLine("Deseja jogar novamente? (s/n)");
          string? opcaoContinuar = Console.ReadLine();
          Console.WriteLine("--------------------------------------------------");

          if (opcaoContinuar?.ToUpper() != "S")
          {
          Console.WriteLine("\nEncerrando o programa. Até mais...\n");
          break;
          }

          Thread.Sleep(1000);
}