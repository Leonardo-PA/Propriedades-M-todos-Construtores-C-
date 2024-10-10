using Exemploexplorando.Models;

Pessoa p1 =new Pessoa(nome: "Leonardo", sobrenome: "Pereira de Andrade");
// p1.Nome = "leonardo";
// p1.Sobrenome = "pereira de andrade";

Pessoa p2 = new Pessoa(nome: "Eduardo",sobrenome: "Neves Queiroz"); //está susbistuindo usando um construtor e para os parametros, porém justificar sempre.
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Neves Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



// Pessoa p1 = new Pessoa();   //Nesse caso estamos estanciando uma variavel e salvando ela de forma que assuma o lugar de P1
// p1.Nome= "leonardo";
// p1.Sobrenome = "pereira de andrade";
// p1.Idade = 24;  //colocou valor de igual está atribuindo um SET 
// p1.Apresentar();    //não inseriu o valor de = então estão atribuindo o GET

// //quando fazemos isso com P1 significa que estamos atriubuindo ao meu p1 um valor de propriedade como idade ou nome



