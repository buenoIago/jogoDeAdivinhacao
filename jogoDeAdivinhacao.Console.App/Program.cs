using System;
using System.Security.Cryptography;

class Program
{
  static void Main(string [] args)
  {
      while (true)
      {

        string? dificuldadeEscolhida = ExibirMenuEscolhaDificuldade();

        int[] configuracoes = ConfigurarPartida(dificuldadeEscolhida);

        int numeroMaximo = configuracoes[0];
        int tentativasMaximas = configuracoes[1];

        ExecutarPartida(numeroMaximo, tentativasMaximas);

        if (!jogadorDesejaContinuar())
           break;
          
        Thread.Sleep(1000);        
      }
  }
  static string? ExibirMenuEscolhaDificuldade()
  {
    Console.Clear();

    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Bem Vindo ao Jogo de Adivinhação! ");
    Console.WriteLine("--------------------------------------------------"); 
    Thread.Sleep(1000);

    Console.WriteLine("Carregando o jogo...");  
    Console.WriteLine("--------------------------------------------------");
    Thread.Sleep(2000);
    Console.WriteLine("Iniciando uma nova rodada...\n");  
    Thread.Sleep(1000);

    Console.WriteLine("Escolha o nível de dificuldade: \n1 - Fácil (10 tentativas)\n2 - Médio (5 tentativas)\n3 - Difícil (3 tentativas)");
        
    Console.Write("Digite sua escolha: ");
    string dificuldade = Console.ReadLine();

    return dificuldade;

    static bool jogadorDesejaContinuar()
    {
        Console.WriteLine("Deseja jogar novamente? (s/n)");
        string? opcaoContinuar = Console.ReadLine();
        
          if (opcaoContinuar?.ToUpper() != "S")
          {
          Thread.Sleep(750);
          Console.WriteLine("--------------------------------------------------");
          Console.WriteLine("Encerrando o programa. Até mais...");
          Console.WriteLine("--------------------------------------------------");
          return false;
          }

      return true;    
    }
  }
}