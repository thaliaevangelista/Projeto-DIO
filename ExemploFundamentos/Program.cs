using ExemploFundamentos.Models;

//Operador AND (&&) - Retorna true somente se ambas as expressões forem verdadeiras.

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado.");
}



// // Operador OR (||) - Retorna true se pelo menos uma das expressões for verdadeira.

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada autorizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, você não tem autorização para entrar.");
// }



//if e else

// int quantidadeEstoque = 10;
// int quantidadeComprada = 4;
// bool possivelVenda = quantidadeEstoque >= quantidadeComprada;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade comprada: {quantidadeComprada}");
// Console.WriteLine($"É possível realizar a venda? {quantidadeEstoque >= quantidadeComprada}");


// if (quantidadeEstoque >= quantidadeComprada)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }






// string a = "15";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");




//int a = 5;
//double b = a;

//int a = 5;
//long b = a;


//double a = 4 / 2 +2;

//Console.WriteLine(a);




/*Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Thalia";
pessoa1.Idade = 28;
pessoa1.Apresentar();*/
