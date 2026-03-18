
namespace exercicios_curso_jogos_digitais
{
    public static class Arvore
    {
        public static void DesenharCopa(int tamanho)
        {
            int espacoVazio = tamanho;
            Console.Clear();
            Console.WriteLine($"\n------------------ FELIZ NATAL -------------------\n\n");

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = espacoVazio - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }

                int copa = tamanho - espacoVazio + 1;

                for (int c = 0; c < (copa * 2) - 1; c++)
                {
                    Console.Write("*");
                }
                espacoVazio--;

                Console.WriteLine();
                Thread.Sleep(100);
            }
        }

        public static void DesenharTronco(int tamanho)
        {
            int tamanhoReal = tamanho * 2;
            int espacoVazio = (int)((tamanhoReal / 2) * 0.8);
            int tronco = (int)((tamanhoReal / 2) * 0.4);

           

            for (int i = 0; i < tamanho * 0.2 ; i++)
            {
                for (int j = espacoVazio; j > 0; j--)
                {
                    Console.Write(" ");   
                }

                for (int c = 0; c < tronco; c++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                Thread.Sleep(100);
            }
            
            for(int f = 0 ; f < tamanhoReal ; f++ )
            {
                Console.Write("*");
            }

            Console.WriteLine("\n\n");
        }
    }
}