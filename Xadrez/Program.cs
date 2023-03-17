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
            Tela.imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeOrigem(origem);
            // limpar o tab para imprimir com as possiveis posições
            bool[,] posicoesPossiveis = partida.tab.peca(origem).movPossiveis();
            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeDestino(origem, destino);
            partida.realizaJogada(origem, destino);
        }
        catch(TabuleiroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }



    }

    Tela.imprimirTabuleiro(partida.tab);
}
catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();