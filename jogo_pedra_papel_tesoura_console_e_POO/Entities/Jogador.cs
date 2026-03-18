namespace Desafio_jogo_pedraPapelTesoura
{
    public class Jogador
    {
        public string Nome {get; set;}
        public int Escolha {get; set;}

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public void Escolher(int opcao)
        {
            Escolha = opcao;
        }
    }
}