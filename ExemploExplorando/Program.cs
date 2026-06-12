using System.Data;
using System.Globalization;
using ExemploExplorando.Models;

// TryParse 

String dataString = "2026-06-11 22:30";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                            CultureInfo.InvariantCulture, 
                            DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"Não é uma data válida");
}
















//Formatando um Date Time

// DateTime data = DateTime.Now; 

// Console.WriteLine(data);
















//alterando e localizando cultura

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 82.40M;

// Console.WriteLine(valorMonetario.ToString("N1"));

// double porcentagem = .34;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("## ## ##"));
























// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





















// Pessoa p1 = new Pessoa(nome:"Thalia", sobrenome:"Soares");
// Pessoa p2 = new Pessoa(nome:"Alex", sobrenome: "Rafael");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();























// p1.Idade = 28;

// p1.Apresentar();




