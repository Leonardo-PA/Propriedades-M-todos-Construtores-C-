using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploexplorando.Models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)//sempre vai ter o mesmo nome da sua classe, e ele não possuiu um retorno. 
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome; // Usamos o _nome para poder armazenar os valores 
        private int _idade; //Usado para validar o valor de idade

        public string Nome 
        { 
            get =>_nome.ToUpper();//Toupper para tornar maiusculo o meu nome 
            // tornado sucinto o metodo porem pode ser feito com o Return

            set
            {
                if (value == "") //value é o argumento que está recebendo o nome.
                {
                    throw new ArgumentException("O nome não pode ser vazio"); //significa que vai ser uma exessão que o codigo vai gerar para apresentar que não foi atribuido valor, impedidindo que o codigo continue a executar. 
                } // função principal pegar e jogar pra fora caso o meu value esteja vazio. 

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        {     
            get => _idade; 

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            } 
        
        }//se eles estiver vazio ele aceitas qualquer valor que for atribuido a ele. 

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}"); //nome e idade são exemplos de GET e SET dentro da minha propriedade
        }

    }
}