using ExemploFundamentos.Models;

//laço de repetição for

int numero = 5;

Console.WriteLine($"{numero} x 1= {numero * 1}");

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}






// Calculadora calc = new Calculadora();


// //raiz quadrada
// calc.RaizQuadrada(9);




// //Incremento e Decremento
// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incremento a 10");
// //numeroIncremento = numeroIncremento + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);

// Console.WriteLine("Decremento a 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);





// //seno, coseno e tangente
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);





//Calculadora soma, subtração, multiplicação, divisão e potenciação
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
//calc.Potencia(3, 3);

























// //Operador Not (!) - Retorna o valor booleano oposto da expressão.

// bool choveu = true;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vamos peladar");
// }
// else
// {
//     Console.WriteLine("Vamos ficar em casa.");
// }




// //Operador AND (&&) - Retorna true somente se ambas as expressões forem verdadeiras.

// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado.");
// }



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
