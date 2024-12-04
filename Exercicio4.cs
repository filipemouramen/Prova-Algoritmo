using System;
class HelloWorld {
  static void Main() {
      
      Console.WriteLine("Escreva uma data no formato ao lado, contendo as barras: dd/MM/yyyy");
      string date1 = Console.ReadLine();
      
      Console.WriteLine("Escreva uma data no formato ao lado, contendo as barras: dd/MM/yyyy");
      string date2 = Console.ReadLine();
     
      
      DateTime date11 = DateTime.ParseExact(date1, "dd/MM/yyyy", null);
      DateTime date22 = DateTime.ParseExact(date2, "dd/MM/yyyy", null);
      
      TimeSpan diferenca = date22 - date11;
      
      int diferencadias = Math.Abs(diferenca.Days);
      
      Console.WriteLine("A difereça de dias é de: " + diferencadias);
  }
}