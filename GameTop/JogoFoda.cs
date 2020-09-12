using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            this._jogador1 = jogador1;
            this._jogador2 = jogador2;
        }
        public void InciarJogo(){
            System.Console.WriteLine(_jogador1.Chutar());
            System.Console.WriteLine(_jogador1.Passar());
            System.Console.WriteLine(_jogador1.Correr());
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Próximo Jogador");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine(_jogador2.Correr());
            System.Console.WriteLine(_jogador2.Chutar());
            System.Console.WriteLine(_jogador2.Passar());
        }
    }
    
}