using System;
class HelloWorld {
  static void Main() {
      
      Console.WriteLine("Escreva uma frase qualquer:");
      string frase = Console.ReadLine();
      
      
      string [] numero = frase.Split();
      int numpalavras = numero.Length;
      
      Console.WriteLine("O número de palavras na sua frase é:");
      Console.WriteLine(numpalavras);
  }
}