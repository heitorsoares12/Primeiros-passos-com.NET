using System;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Pilha();
            Console.WriteLine("Vamos comecar o processo de empilhamento !!");
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine("Vamos comecar o processo de desempilhamento !!");
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
           
        }
    }
}
