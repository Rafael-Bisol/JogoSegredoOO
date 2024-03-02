using System;

namespace JogoSegredoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();

            Console.WriteLine("Bem-vindo ao jogo de adivinhar o segredo!");
            Console.Write("Comece digitando o segredo: ");
            jogo.segredo = Console.ReadLine().ToLower();
            Console.Write("Agora digite uma descrição do segredo: ");
            jogo.dica = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Você tem 5 tentativas! Boa sorte!");
            Console.WriteLine("Sua dica é: " + jogo.dica);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Tentativa nº{i}: ");
                string tentativa = Console.ReadLine().ToLower();

                if (jogo.Resultado(tentativa))
                {
                    Console.WriteLine("Você ganhou! Parabéns!");
                    break;
                }
                else
                {
                    Console.Write("Você errou!");
                    if (i < 4) Console.Write(" Tente novamente!");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Fim do jogo!");
        }
    }
}
