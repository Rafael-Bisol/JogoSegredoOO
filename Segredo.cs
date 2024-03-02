namespace JogoSegredoOO
{
    class Segredo
    {
        public string segredo;
        public string dica;

        public bool jogada(string tentativa)
        {
            return segredo == tentativa;
        }
    }
}