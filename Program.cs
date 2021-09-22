using System;
using static System.Console;

namespace Tabuada_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int rec;

            rec = 1;
            while(rec > 0 & rec < 2)      
            {    
                WriteLine(""); 

                WriteLine("Tabuada do Número: ");
                n = Convert.ToInt32(ReadLine());

                for(int i = 1 ; i<11 ; i++){
                    WriteLine($"{i} x {n} = {i * n}");
                };

                WriteLine(""); 

                WriteLine("Para recalcular, digite 1 e pressione ENTER. Para fechar, digite 0 e pressione ENTER");
                rec = Convert.ToInt32(ReadLine()); 

                WriteLine(""); 
                WriteLine("------------------");
                WriteLine(""); 
            }

            WriteLine(" Obrigado por utilizar o programa !! "); 

            WriteLine(""); 
        }
    }
}
