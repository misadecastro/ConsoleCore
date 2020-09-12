using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _Nome;

        public Jogador2(string nome)
        {
            _Nome = nome;
        }

        public string Chutar()
        {
            return $"{_Nome} esta pateando \n";
        }

        public string Passar()
        {
            return $"{_Nome} está pasando \n";
        }

        public string Correr()
        {
            return $"{_Nome} está corriendo \n";
        }
    }
}