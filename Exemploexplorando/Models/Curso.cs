using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploexplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } //lista é uma coleção de um tipo, nesse caso Pessoa

        public void AdicionarAluno(Pessoa aluno) //assinatura de um metodo, desde Void até o final das seções. //Void significa sem retorno
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count; //Count retorna a quantidade de alunos listados na lista Pessoa
            return quantidade; //para que ele entenda que terminou é necessario inserir o return se não ele se perde
        }
        public void RemoverAluno(Pessoa aluno) 
        {
            Alunos.Remove(aluno);
        }
    }
}