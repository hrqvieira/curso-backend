﻿using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Quantos valores você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int val = 0;
            int contIn = 0;
            int contOut = 0;

            for(int i = 1; i <= n;  i++)
            {
                Console.Write("Digite o {0} valor: ", i);
                val = int.Parse(Console.ReadLine());

                if (val >= 10 && val <= 20)
                {
                    contIn++;
                } else 
                {
                    contOut++;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");

            //Console.WriteLine("Digite um numero: ");
            //int x = int.Parse(Console.ReadLine());

            //if(x >= 1 && x <= 1000)
            //{
            //    for(int i = 1; i <= x; i++)
            //    {
            //        if(i % 2 != 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Numero inválido.");
            //}







            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int n = int.Parse(Console.ReadLine());


            //int soma = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("Valor #{0}: ", i);
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}

            //Console.WriteLine("Soma: " + soma);





            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;
            //Console.WriteLine("Escolha uma opção:");
            //Console.WriteLine("1 - Alcool");
            //Console.WriteLine("2 - Gasolina:");
            //Console.WriteLine("3 - Diesel");
            //Console.WriteLine("4 - FIM");
            //Console.WriteLine("  ");
            //string opc = Console.ReadLine();

            //while (opc != "4")
            //{
            //    if (opc == "1")
            //    {
            //        alcool++;
            //    } else if (opc == "2")
            //    {
            //        gasolina++;
            //    } else if (opc == "3")
            //    {
            //        diesel++;
            //    }

            //    Console.WriteLine("Selecione outra opção");
            //    opc = Console.ReadLine();
            //    Console.WriteLine("  ");
            //}

            //Console.WriteLine("MUITO OBRIGADO!");
            //Console.WriteLine("Alcool: " + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: " + diesel);






            //Console.WriteLine("Digite sua senha: ");
            //string inputSenha = Console.ReadLine();
            //string senhaCorreta = "2002";

            //while(inputSenha != senhaCorreta) {

            //    Console.WriteLine("Senha incorreta, tente novamente: ");
            //    inputSenha = Console.ReadLine();
            //}

            //Console.WriteLine("Logado com sucesso");




        }



        //Console.WriteLine("Digite um numero");
        //double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //int vezes = 0;

        //while (n1 >= 0.0) {
        //    double raiz = Math.Sqrt(n1);
        //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
        //    Console.WriteLine("Digite outro numero");
        //    n1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        //    vezes++;
        //}

        //Console.WriteLine("Número negativo");


        //Console.WriteLine("Digite 3 números:");
        //    int n1 = int.Parse(Console.ReadLine());
        //int n2 = int.Parse(Console.ReadLine());
        //int n3 = int.Parse(Console.ReadLine());


        //double resultado = Maior(n1, n2, n3);

        //Console.WriteLine("Maior = " + resultado);





        //static int Maior(int a, int b, int c) {
        //    int m;

        //    if (a > b && a > c)
        //    {
        //        m = a;
        //    }
        //    else if (b > c)
        //    {
        //        Console.WriteLine(m = b);
        //    }
        //    else
        //    {
        //        Console.WriteLine(m = c);
        //    }

        //    return m;
        //}


        //Console.WriteLine("Digite um número: ");
        //double intervalo = double.Parse(Console.ReadLine());

        //if (intervalo < 0.25)
        //{
        //    Console.WriteLine("Fora de intervalo");

        //}
        //else if (intervalo <= 25.50 && intervalo > 0.25)
        //{
        //    Console.WriteLine("Intervalo [25,50]");

        //}
        //else if (intervalo <= 50.75)
        //{
        //    Console.WriteLine("Intervalo [50,75]");

        //}
        //else if (intervalo <= 75.10 || intervalo > 74.10)
        //{
        //    Console.WriteLine("Intervalo [75,100]");
        //}
        //else 
        //{
        //    Console.WriteLine("intervalor de [0,25]");
        //}




        //string[] valores = Console.ReadLine().Split(' ');
        //int pedido = int.Parse(valores[0]);
        //double quantidade = double.Parse((valores[1]));
        //double valor = 0;


        //if (pedido == 1)
        //{
        //    valor = 4.00;
        //}
        //else if (pedido == 2)
        //{
        //    valor = 4.50;
        //}
        //else if (pedido == 3)
        //{
        //    valor = 5.00;
        //}
        //else if (pedido == 4)
        //{
        //    valor = 2.00;
        //}
        //else 
        //{
        //    valor = 1.50;
        //}

        //double total = valor * quantidade;
        //Console.WriteLine("Seu pedido deu: R$" + total.ToString("F2"));


        //Console.WriteLine("Digite dois números:");
        //int horaInicial = int.Parse(Console.ReadLine());
        //int horaFinal = int.Parse(Console.ReadLine());
        //int duracao = 0;

        //if (horaInicial < horaFinal) {
        //    duracao = horaFinal - horaInicial;
        //} else
        //{
        //    duracao = 24 - horaInicial + horaFinal;
        //}

        //Console.WriteLine("O jogo durou " + duracao + " horas");


        //Console.WriteLine("Digite um número:");
        //int num = int.Parse(Console.ReadLine());
        //int num2 = int.Parse(Console.ReadLine());

        //if (num % num2 == 0 || num2 % num == 0) {
        //    Console.WriteLine("São multiplos");
        //} else {
        //    Console.WriteLine("Não são multiplos");
        //}






        //Console.WriteLine("Digite um número:");
        //int num = int.Parse(Console.ReadLine());

        //if (num % 2 == 0) {
        //    Console.WriteLine("Número par");
        //}
        //else {
        //    Console.WriteLine("Número impar");
        //}



        //Console.WriteLine("Digite um numero:");
        //int num = int.Parse(Console.ReadLine());

        //if (num > 0) {
        //    Console.WriteLine("Número positivo");
        //} else if (num < 0) {
        //    Console.WriteLine("Número negativo");
        //} else {
        //    Console.WriteLine("0 é num numero neutro!");
        //}











        //Console.WriteLine("Qual a hora atual?");
        //int horario = int.Parse(Console.ReadLine());


        //if (horario < 12) {
        //    Console.WriteLine("Bom dia!");
        //}  else if ( horario < 18) {
        //    Console.WriteLine("Boa tarde!");
        //} else {
        //    Console.WriteLine("Boa noite!");
        //}


        //Console.WriteLine("Entre com um numero inteiro");
        //int x = int.Parse(Console.ReadLine());


        //if (x % 2 == 0)
        //{
        //    Console.WriteLine("Par");
        //}
        //else {
        //    Console.WriteLine("Impar");
        //}




        //Console.WriteLine("Bom dia!");


        //if (x > 5) {
        //    Console.WriteLine("Boa tarde!");
        //}


        //Console.WriteLine("Boa noite!");






        //bool c1 = 2 > 3 || 4 != 5; //true
        //bool c2 = !(2 > 3) && 4 != 5; //true



        //Console.WriteLine(c1);
        //Console.WriteLine(c2);
        //Console.WriteLine("<----------->");


        //bool c3 = 10 < 5; //false
        //bool c4 = c1 || c2 && c3;

        //Console.WriteLine(c3);
        //Console.WriteLine(c4);


        //int a = 10;
        //bool c1 = a < 10;
        //bool c2 = a < 20;
        //bool c3 = a > 10;
        //bool c4 = a > 5;

        //Console.WriteLine(c1);
        //Console.WriteLine(c2);
        //Console.WriteLine(c3);
        //Console.WriteLine(c4);

        //Console.WriteLine("<------------->");

        //bool c5 = a <= 10;
        //bool c6 = a >= 10;
        //bool c7 = a == 10;
        //bool c8 = a != 10;

        //Console.WriteLine(c5);
        //Console.WriteLine(c6);
        //Console.WriteLine(c7);
        //Console.WriteLine(c8);



        //string[] vet = Console.ReadLine().Split(' ');

        //float a = float.Parse(vet[0], CultureInfo.InvariantCulture);
        //float b = float.Parse(vet[1], CultureInfo.InvariantCulture);
        //float c = float.Parse(vet[2], CultureInfo.InvariantCulture);
        //float pi = 3.14159F;

        //float triangulo = a * c / 2;
        //float circulo = pi * (c * c);
        //float trapezio = (a + b) * c / 2;
        //float quadrado = b * 4;
        //float retangulo = a * b;

        //Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        //Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        //Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        //Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        //Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));



        //string[] peca1 = Console.ReadLine().Split(' ');
        //string[] peca2 = Console.ReadLine().Split(' ');

        //float cod1 = float.Parse(peca1[0]);
        //float num1 = float.Parse(peca1[1], CultureInfo.InvariantCulture);
        //float val1 = float.Parse(peca1[2], CultureInfo.InvariantCulture);
        //float total1 = num1 * val1;



        //float cod2 = float.Parse(peca2[0]);
        //float num2 = float.Parse(peca2[1], CultureInfo.InvariantCulture);
        //float val2 = float.Parse(peca2[2], CultureInfo.InvariantCulture);
        //float total2 = num2 * val2;


        //float total = total1 + total2;

        //Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));






        //float num = int.Parse(Console.ReadLine());
        //float horas = int.Parse(Console.ReadLine());
        //float salarioHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //float salario = horas * salarioHora;

        //Console.WriteLine("NUMBER: " + num);
        //Console.WriteLine("SALARY: " + salario.ToString("F2", CultureInfo.InvariantCulture));


        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());
        //int d = int.Parse(Console.ReadLine());

        //int dif = a * b - c * d;

        //Console.WriteLine("DIFERENÇA: " + dif);



        //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //double pi = 3.14159;


        //double area = pi * (raio * raio);

        //Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));



        //int num1 = int.Parse(Console.ReadLine());
        //int num2 = int.Parse(Console.ReadLine());
        //int soma = num1 + num2;
        //Console.WriteLine("SOMA = " + soma);


        //string nome = Console.ReadLine();
        //string numQuartos = Console.ReadLine();
        //float produto = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //string[] vet = Console.ReadLine().Split(' ');
        //string sobrenome = vet[0];
        //int idade = int.Parse(vet[1]);
        //float altura = float.Parse(vet[2], CultureInfo.InvariantCulture);

        //Console.WriteLine(nome);
        //Console.WriteLine(numQuartos);
        //Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
        //Console.WriteLine(sobrenome);
        //Console.WriteLine(idade);
        //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



        //int n1 = int.Parse(Console.ReadLine());
        //char ch = char.Parse(Console.ReadLine());
        //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //string[] vet = Console.ReadLine().Split(' ');

        //string nome = vet[0];
        //char sexo = char.Parse(vet[1]);
        //int idade = int.Parse(vet[2]);
        //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        //Console.WriteLine("Você digitou: ");
        //Console.WriteLine(n1);
        //Console.WriteLine(ch);
        //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        //Console.WriteLine(nome);
        //Console.WriteLine(idade);
        //Console.WriteLine(sexo);
        //Console.WriteLine(altura);




        //string frase = Console.ReadLine();
        //string x = Console.ReadLine();
        //string y = Console.ReadLine();
        //string z = Console.ReadLine();


        //string[] vet = Console.ReadLine().Split(' ');
        //string p1 = vet[0];
        //string p2 = vet[1];
        //string p3 = vet[2];


        //Console.WriteLine(" ");
        //Console.WriteLine(" ");
        //Console.WriteLine("Você digitou: ");
        //Console.WriteLine(" ");
        //Console.WriteLine(" ");
        //Console.WriteLine(frase);
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //Console.WriteLine(z);
        //Console.WriteLine(p1);
        //Console.WriteLine(p2);
        //Console.WriteLine(p3);

        //int a = 5;
        //int b = 2;

        //double resultado = (double) a / b;

        //Console.WriteLine(resultado);


        //string produto1 = "Computador";
        //string produto2 = "Mesa de escritório";

        //byte idade = 30;
        //int codigo = 5290;
        //char genero = 'M';

        //double preco1 = 2100.00;
        //double preco2 = 650.50;
        //double medida = 53.234567;

        //Console.WriteLine("Produtos:");
        //Console.WriteLine($"{produto1}, cujo preço é ${preco1:f2}");
        //Console.WriteLine($"{produto2}, cujo preço é ${preco2:F2}");
        //Console.WriteLine(" ");
        //Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
        //Console.WriteLine(" ");
        //Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
        //Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
        //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));



        //int idade = 32;
        //double saldo = 10.35784;
        //string nome = "Maria";


        //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

        //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

        //Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


        //Console.Write("Bom dia!");
        //Console.WriteLine("Boa tarde!");
        //Console.WriteLine("Boa noite!");
        //Console.WriteLine("----------------------");
        //Console.WriteLine(genero);
        //Console.WriteLine(idade);
        //Console.WriteLine(saldo);
        //Console.WriteLine(nome);
        //Console.WriteLine(saldo.ToString("F2"));
        //Console.WriteLine(saldo.ToString("F4"));
        //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));



        //    int n1 = int.MinValue;
        //    int n2 = int.MaxValue;
        //    sbyte n3 = sbyte.MinValue;
        //    decimal n4 = decimal.MaxValue;

        //    Console.WriteLine(n4);
        //    Console.WriteLine(n3);
        //    Console.WriteLine(n1);
        //    Console.WriteLine(n2);




        //bool completo = false;
        //char genero = 'F';
        //char letra = '\u0041';
        //byte n1 = 126;
        //int n2 = 1000;
        //int n3 = 2147483647;
        //long n4 = 2147483648L;
        //float n5 = 4.5f;
        //double n6 = 4.5;
        //string nome = "Maria Green";
        //object obj1 = "Alex Brown";
        //object obj2 = 4.5f;


        //Console.WriteLine(obj1);
        //Console.WriteLine(obj2);
        //Console.WriteLine(nome);
        //Console.WriteLine(n5);
        //Console.WriteLine(n6);
        //Console.WriteLine(letra);
        //Console.WriteLine(genero);
        //Console.WriteLine(completo);
        //Console.WriteLine(n1);
        //Console.WriteLine(n2);
        //Console.WriteLine(n3);
        //Console.WriteLine(n4);

    }
}