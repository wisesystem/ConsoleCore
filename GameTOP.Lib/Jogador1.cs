using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        
        //chuta
        public string Chuta()
        {
            return $"{_Nome} está Chutando \n";            
        }
        //Corre
        public string Corre()
        {
           return $"{_Nome} está Correndo \n";            
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} está Passando \n";
        }

    }
}