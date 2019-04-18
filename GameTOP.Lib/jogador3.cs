using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class jogador3 : iJogador
    {
        string iJogador.Chuta()
        {
            return "Teste Chuta \n";
        }

        string iJogador.Corre()
        {
            return "Teste Corre \n";
        }

        string iJogador.Passe()
        {
            return "Teste Passe \n";
        }
    }
}