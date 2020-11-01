using System;

namespace media4notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;
            double mediaFinal;
            Console.Write("Digite sua 1ªNota: ");
            nota1 = double.Parse(Console.ReadLine());

            if (nota1 < 0 || nota1 > 10)
             {
                 Console.Write("Digite somente números de 0 a 10");
                 Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                 Console.ReadKey();
                 Environment.Exit(-1);
             }
            
            Console.Write("Digite sua 2ªNota: ");
            nota2 = double.Parse(Console.ReadLine());

             if (nota2 < 0 || nota2 > 10)
              { 
                 Console.Write("Digite somente números de 0 a 10");
                 Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                 Console.ReadKey();
                 Environment.Exit(-1);
              }


            Console.Write("Digite sua 3ªNota: ");
            nota3 = double.Parse(Console.ReadLine());

            if (nota3 < 0 || nota3 > 10) 
             {
                 Console.Write("Digite somente números de 0 a 10");
                 Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                 Console.ReadKey();
                 Environment.Exit(-1);
             }



            Console.Write("Digite sua 4ªNota: ");
            nota4 = double.Parse(Console.ReadLine());

            if (nota4 < 0 || nota4 > 10)
             {
                 Console.Write("Digite somente números de 0 a 10");
                 Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                 Console.ReadKey();
                 Environment.Exit(-1);
             }



            mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

           if (mediaFinal >= 7 )  
           {
           Console.WriteLine();
           Console.WriteLine($"Sua media final é de {Math.Round(mediaFinal, 1)}");
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine("Meus parabéns,você FOI APROVADO!!!");
           Console.ResetColor();  
           }

           else if (mediaFinal >= 5 && mediaFinal <= 6) 
           {
          Console.WriteLine();
          Console.WriteLine($"Sua media final é de{Math.Round(mediaFinal, 1 )}");
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("Você ficou de RECUPERAÇÃO!!!");
          Console.ResetColor();
           }
     
          else 
          {

         Console.WriteLine();
         Console.WriteLine($"Sua media final é de{Math.Round(mediaFinal, 1 )}");
         Console.ForegroundColor =ConsoleColor.Red;
         Console.WriteLine("Você foi REPROVADO!!!");
         Console.ResetColor();
          
          }
        }
    }
}

