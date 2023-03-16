using tabuleiro;
using tela;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada) 
    {

        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);

    }

    Tela.imprimirTabuleiro(partida.tab);
}
catch(TabuleiroException ex)
{
    Console.WriteLine(ex.Message) ;
}
Console.ReadLine();