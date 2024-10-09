using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploexplorando.Models
{
    public class Pessoa
    {
        private string _nome; // Usamos o _nome para poder armazenar os valores 
        public string Nome 
        { 
            get 
            {
                return _nome.ToUpper();//Toupper para tornar maiusculo o meu nome
            }

            set
            {
                if (value == "") //value é o argumento que está recebendo o nome.
                {
                    throw new ArgumentException("O nome não pode ser vazio"); //significa que vai ser uma exessão que o codigo vai gerar para apresentar que não foi atribuido valor, impedidindo que o codigo continue a executar. 
                } // função principal pegar e jogar pra fora caso o meu value esteja vazio. 

                _nome = value;
            } 
        }

        public int Idade { get; set; }//se eles estiver vazio ele aceitas qualquer valor que for atribuido a ele. 

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}"); //nome e idade são exemplos de GET e SET dentro da minha propriedade
        }

    }
}