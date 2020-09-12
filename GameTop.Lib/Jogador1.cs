using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public string Chutar()
        {
            return $"{_Nome} está chutando \n";
        }

        public string Passar()
        {
            return $"{_Nome} está passando \n";
        }

        public string Correr()
        {
            return $"{_Nome} está correndo \n";
        }
    }
}