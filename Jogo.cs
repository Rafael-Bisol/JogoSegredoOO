namespace JogoSegredoOO
{
    class Jogo
    {
        public string segredo;
        public string dica;

        public bool Resultado(string tentativa)
        {
            return segredo == tentativa;
        }
    }
}