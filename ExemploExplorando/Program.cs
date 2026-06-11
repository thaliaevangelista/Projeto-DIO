using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Thalia", sobrenome:"Soares");
Pessoa p2 = new Pessoa(nome:"Alex", sobrenome: "Rafael");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();























// p1.Idade = 28;

// p1.Apresentar();




