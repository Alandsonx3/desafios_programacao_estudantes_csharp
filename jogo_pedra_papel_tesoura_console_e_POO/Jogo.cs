
namespace Desafio_jogo_pedraPapelTesoura
{
    public class Jogo
    {
        public void IniciarJogo()
        {
            // Coletar as informações do usuário;
            Console.Clear();
            Console.WriteLine("##  (PEDRA VS PAPEL VS TESOURA) ##\n");
            Console.WriteLine("## -------- ✊  ✋  ✌️  -------- ##\n");

            Console.Write("=> Nome do jogador: ");
            string nomeJogador = Console.ReadLine()!;

            Console.Write("=> Nome do oponente: ");
            string nomeMaquina = Console.ReadLine()!;

            Console.Write("\nEscolha sua jogada:\n\n=> 1 - ✊ \n=> 2 - ✋ \n=> 3 - ✌️");

            Console.Write("\n\nOpção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            // Instanciar o jogador;
            Jogador jogador = new Jogador(nomeJogador);
            jogador.Escolher(opcao);

            // Instanciar o computador;
            Computador maquina = new Computador(nomeMaquina);
            maquina.Escolher();

            // Chamando o método de comparar as jogadas;
            CompararJogadas(jogador, maquina);
        }

        public void CompararJogadas(Jogador jogador, Computador maquina)
        {
            string[] opcoes = ["✊", "✋", "✌️"];

            string opcaoJ = opcoes[jogador.Escolha - 1];
            string opcaoM = opcoes[maquina.Escolha - 1];

            string resultado;

            if(opcaoJ == opcaoM)
            {
                resultado = $"Deu empate [{opcaoJ} vs {opcaoM}]";
            }
            else if 
            (
                opcaoJ == "✌️" && opcaoM == "✋" ||
                opcaoJ == "✊" && opcaoM == "✌️" ||
                opcaoJ == "✋" && opcaoM == "✊"
            )
            {
                resultado = $"{jogador.Nome} venceu, {opcaoJ}  => ganha de {opcaoM}";
            }
            else
            {
                resultado = $"{maquina.Nome} venceu, {opcaoM}  => ganha de {opcaoJ}";
            }

            MostrarVencedor($"\n=> Placar: {resultado}");
        }

        public void MostrarVencedor(string resposta)
        {
            Console.WriteLine(resposta);
            Console.ReadKey();
        }
    }
}