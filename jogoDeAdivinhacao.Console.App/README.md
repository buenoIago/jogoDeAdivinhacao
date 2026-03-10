## INTRODUÇÃO

Este jogo de adivinhação foi desenvolvido em C# e funciona no Console. O objetivo do jogador é descobrir um número secreto gerado aleatoriamente pelo programa dentro de um número limitado de tentativas. No início de cada rodada, o jogador escolhe um nível de dificuldade, que define a quantidade de tentativas disponíveis e o intervalo possível do número secreto, além de impedir números repetidos e registrar os chutes realizados. Ao final da rodada, o jogador pode iniciar uma nova partida ou encerrar o jogo.

## FUNCIONALIDADES

* Interface de boas-vindas e mensagem de carregamento do jogo.
* Sistema de dificuldade (fácil, médio, difícil).
* Contagem e exibição das tentativas durante a rodada.
* Geração de número secreto aleatório 
* Impedir números repetidos.
* Mostrar se o número é maior ou menor que o secreto.
* Mensagem de vitória quando o jogador acerta o número.
* Mensagem de derrota quando todas as tentativas são usadas.
* Opção de iniciar uma nova rodada após o término da partida.
* Sistema de pontuação baseado no desempenho do jogador
* Exibição da pontuação ao final de cada rodada.

## Como utilizar o programa

1. Clone o repositório ou baixo o código comprimido em .zip.
2. Abra o emulador de terminal e navegue até a pasta raiz.
3. Utilize o comando abaixo para restaurar as dependências do projeto.

     ```
     dotnet restore
     ```

4. Em seguida compile e execute o projeto com o comando: 

    ```
    dotnet run --project jogoDeAdivinhacao.Console.App
    ```

## Requistitos

* .NET SDK 10.0