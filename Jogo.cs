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

        // Valor inicial, caso não declarado
        public Jogo(){
            segredo = "";
            dica = "";
        }
        
        // É possível só enviar um argumento ao objeto Jogo
        public Jogo(string segredo) {
            this.segredo = segredo;
        }

        // Também é possível enviar dois argumentos
        public Jogo(string segredo, string dica) : this(segredo) {
            this.dica = dica;
        }

        public override string ToString()
        {
            return $"Segredo: {segredo}\nDica: {dica}";
        }
    }
}