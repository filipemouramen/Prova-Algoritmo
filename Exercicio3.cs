using System;
class HelloWorld {
	static void Main() {

		int valor, resto, anos, meses, dias;

		Console.WriteLine("Escreva um número inteiro, correspondente ao número de dias!");
		valor = int.Parse(Console.ReadLine());

		int ano = 365;
		int mes = 30;

		anos = valor / ano;
		resto = valor % ano;

		meses = resto / mes;
		dias = resto % mes;

		Console.WriteLine("A quantidade de ano(s) é: " + anos);
		
		Console.WriteLine("A quantidade de mes(es) é: " + meses);
		
		Console.WriteLine("A quantidade de dia(s) é: " + dias);
	}
}
