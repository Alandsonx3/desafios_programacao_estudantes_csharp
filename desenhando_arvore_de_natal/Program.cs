// Solicitar ao usuário a altura da árvore.
using exercicios_curso_jogos_digitais;

Console.Write("Informa o tamanho da copa da arvore: ");
int tamanho = int.Parse(Console.ReadLine()!);

// Desenhar a copa da árvore usando *.
Arvore.DesenharCopa(tamanho);
Arvore.DesenharTronco(tamanho);