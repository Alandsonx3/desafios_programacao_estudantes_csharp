namespace Desafio_jogo_pedraPapelTesoura
{
    public class Computador
    {
        public string Nome {get; set;}
        public int Escolha {get; set;}

        public Computador(string nome)
        {
            Nome = nome;
        }

        public void Escolher()
        {
            Escolha = new Random().Next(1,4);
        }
    }
}