using System;

namespace JogoSegredoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo de adivinhar o segredo!");
            Console.Write("Comece digitando o segredo: ");
            string segredo = Console.ReadLine().ToLower();
            Console.Write("Agora digite uma descrição do segredo: ");
            string dica = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Você tem 5 tentativas! Boa sorte!");
            Console.WriteLine("Sua dica é: " + dica);

            bool resultado = false;
            for (int i = 1; i <= 5 && !resultado; i++)
            {
                Console.Write($"Tentativa nº{i}: ");
                string tentativa = Console.ReadLine().ToLower();
                resultado = tentativa == segredo;

                if (resultado)
                {
                    Console.Write("Você ganhou! Parabéns!");
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
