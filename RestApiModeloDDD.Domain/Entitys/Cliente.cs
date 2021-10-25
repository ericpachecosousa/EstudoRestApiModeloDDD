using System;

namespace RestApiModeloDDD.Domain.Entitys
{
    public class Cliente : Base
    {



        public Cliente(string nome, int idade)
        {

        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }

        public const int MaiorIdade = 18;
        public bool MaiorDeIdade(int idade)
        {
            if (Idade < MaiorIdade)
                return false;

            return true;
        }
    }
}