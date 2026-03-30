public static class JogoEmAndamento
{
  static void ExecutarPartida(int numeroMaximo, int tentativasMaximas)
  {

    int[] numerosDigitados = new int [tentativasMaximas];
    int contadorNumerosDigitados = 0;
    int pontuacao = 1000;

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
        Console.WriteLine("--------------------------------------------------");
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
        Console.WriteLine("\nO número digitado foi menor que o número secreto.");    
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
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine($"FIM DE JOGO!\nQue pena, Você usou todas as suas tentivas! O número secreto era {numeroAleatorio}.");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.ResetColor();
        Thread.Sleep(2000);
        }     
        Console.WriteLine($"Sua pontuação é {pontuacao}");
        Thread.Sleep(3000);

    }
  }
}