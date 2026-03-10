using System;
using System.Security.Cryptography;

Console.Clear();
Thread.Sleep(3000);
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Bem Vindo ao Jogo de Adivinhação! ");
Console.WriteLine("--------------------------------------------------"); 
Thread.Sleep(1000);

Console.WriteLine("Carregando o jogo...");  
Console.WriteLine("--------------------------------------------------");
Thread.Sleep(2000);

while (true)
{

  int[] numerosDigitados = new int [100];
  int contadorNumerosDigitados = 0;
  int pontuacao = 1000;

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

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numeroMaximo + 1);

      for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++)
      {
        Console.Clear();
        Console.WriteLine($"Tentativa {tentativa} de {tentativasMaximas}");

        Console.WriteLine($"\nDigite um número entre 1 e {numeroMaximo}: ");

        string chute = Console.ReadLine();
        int numeroDigitado = Convert.ToInt32(chute);

        bool numeroRepetido = false;

        for (int indiceChecado = 0; indiceChecado < numerosDigitados.Length; indiceChecado++)
        {
          if (numerosDigitados[indiceChecado] == numeroDigitado)
          {
            numeroRepetido = true;
            break;
          }
        }

          if (numeroRepetido == true)
          {
            Console.WriteLine("\nVocê já digitou esse número, tente novamente!");
            Console.WriteLine("Clique ENTER para continuar...\n");
            Console.ReadLine();
            tentativa--;
            continue;
          }

          if (contadorNumerosDigitados < numerosDigitados.Length)
          {
          numerosDigitados[contadorNumerosDigitados] = numeroDigitado;
          contadorNumerosDigitados++;
          }

          if (numeroDigitado == numeroAleatorio)
          {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Parabéns! Você acertou o número!");
            Console.WriteLine("--------------------------------------------------\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            break;
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
          int diferencaNumerica = Math.Abs(numeroAleatorio - numeroDigitado);

          if (diferencaNumerica >= 10)
          {
            pontuacao -= 100;
          }
          else if (diferencaNumerica >= 5)
          {
            pontuacao -= 50;
          }
          else
          {
            pontuacao -= 20;
          }

          if (tentativa == tentativasMaximas)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FIM DE JOGO!\nQue pena, Você usou todas as suas tentivas! O número secreto era {numeroAleatorio}.");
            Console.ResetColor();
            Thread.Sleep(2000);
          }      
      }
      Thread.Sleep(1000);
      Console.WriteLine($"Sua pontuação é {pontuacao}");
      Console.WriteLine("Clique ENTER para continuar...\n");
      Console.ReadLine();


      Console.WriteLine("Deseja jogar novamente? (s/n)");
      string? opcaoContinuar = Console.ReadLine();
      Console.WriteLine("--------------------------------------------------");

      if (opcaoContinuar?.ToUpper() != "S")
      {
      Thread.Sleep(750);
      Console.WriteLine("Encerrando o programa. Até mais...");
      Console.WriteLine("--------------------------------------------------");
      Thread.Sleep(3000);
      break;
      }
      Console.Clear();
      Thread.Sleep(1000);
      
}