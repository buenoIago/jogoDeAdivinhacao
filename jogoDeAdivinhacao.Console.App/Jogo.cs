public static class Jogo
{
  static int[] ConfigurarPartida(string? dificuldadeEscolhida)
  {
    int numeroMaximo = 0;
    int tentativasMaximas = 0;

    switch (dificuldadeEscolhida)
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
      break;
    }

      int[] configuracoes = new int[2];

      configuracoes[0] = numeroMaximo;
      configuracoes[1] = tentativasMaximas;
      
      return configuracoes;
  }
}