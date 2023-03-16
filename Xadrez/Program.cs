using tabuleiro;
using tela;
using xadrez;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);
    tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 0));
    tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(1, 3));
    tab.colocarPeca(new Torre(Cor.Amarela, tab), new Posicao(2, 4));


    Tela.imprimirTabuleiro(tab);
}
catch(TabuleiroException ex)
{
    Console.WriteLine(ex.Message) ;
}
Console.ReadLine();