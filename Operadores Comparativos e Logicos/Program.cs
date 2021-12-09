using System;

namespace Operadores
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            // OPERADORES COMPARATIVOS

            // > MAIOR
            // < MENOR
            // >= MAIOR OU IGUAL
            // <= MENOR OU IGUAL
            // == IGUAL
            // != DIFERENTE

            //int a = 10;
            //bool c1 =  a < 10;  // bool VARIAVEL(TRUE OR FALSE)
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;





            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);

            //bool c5 = a <= 15;
            //bool c6 = a >= 15;
            //bool c7 = a == 10;
            //bool c8 = a != 10;




            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);



            // OPERADORES LOGICOS

            // & = E
            // || = OU
            // ! NAO

            bool c1 = 2 > 3 && 4 != 5;

            Console.WriteLine(c1); // FALSE

            bool c2 = 2 > 3 || 4 != 5; 

            Console.WriteLine(c2); // TRUE

            bool c3 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c3); // TRUE



            bool c4 = 10 < 5; // FALSE
            bool c5 = c1 || c2 && c3;




        }
    }
}