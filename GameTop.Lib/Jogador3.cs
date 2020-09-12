using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chutar()
        {
            return "Teste Chuta";
        }

        public string Correr()
        {
            return "Teste Corre";
        }

        public string Passar()
        {
            return "Teste Passa";            
        }
    }
}