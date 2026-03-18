using Desafio_jogo_pedraPapelTesoura;

string opcao = "s";

Jogo meuJogo = new Jogo();

do
{
    meuJogo.IniciarJogo();

    Console.Clear();

    Console.Write("\n=> Deseja jogar novamente [s/n]: ");
    opcao = Console.ReadLine()!;

} while(opcao == "s");