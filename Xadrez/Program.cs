using tabuleiro;
using tela;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        try
        {
            Console.Clear();
            Tela.imprimirPartida(partida);


            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeOrigem(origem);
            // limpar o tabuleiro para imprimir com as possiveis posições
            bool[,] posicoesPossiveis = partida.tab.peca(origem).movPossiveis();
            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeDestino(origem, destino);
            partida.realizaJogada(origem, destino);
        }
        catch (TabuleiroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
    }

    Console.Clear();
    Tela.imprimirPartida(partida);
}
catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();