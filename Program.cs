using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1 - ordenar do menor para o maior, mostrar num array
            
            Console.WriteLine("Indique 5 números:");
            Console.Write("Primeiro: ");
            int primeiro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo: ");
            int segundo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Terceiro: ");
            int terceiro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quarto: ");
            int quarto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quinto: ");
            int quinto = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[] { primeiro, segundo, terceiro, quarto, quinto };
            

            Array.Sort(numeros);
            Console.WriteLine(String.Join(",", numeros));
            //foreach (int i in numeros)
            //{ 
            //    Console.WriteLine(i); 
            //}

            Console.ReadKey();
            Console.Clear();

            // Exercicio 2 - identificar do menor para o maior, mas mostrar num array como foram introduzidos

            Console.WriteLine("Indique 5 números:");
            Console.Write("Primeiro: ");
            int um = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo: ");
            int dois = Convert.ToInt32(Console.ReadLine());
            Console.Write("Terceiro: ");
            int tres = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quarto: ");
            int quatro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quinto: ");
            int cinco = Convert.ToInt32(Console.ReadLine());

            int[] numero = new int[] { um, dois, tres, quatro, cinco };

            Console.WriteLine(String.Join(", ", numero));

            Array.Sort(numero);
            foreach (int n in numero)
            {
                Console.Write(n + ", ");
            }

            Console.ReadKey();
            Console.Clear();

            // Exercicio 3 - mostrar a média dos numeros introduzidos mostrar os numeros iniciais num array

            
            float somavalores, resultado;

            Console.WriteLine("Indique 5 números:");
            Console.Write("Primeiro: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo: ");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Terceiro: ");
            float c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quarto: ");
            float d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quinto: ");
            float e = Convert.ToInt32(Console.ReadLine());

            float[] valores = new float[] { a, b, c, d, e };

            Console.WriteLine(String.Join(", ", valores));

            somavalores = a + b + c + d + e;
            resultado = somavalores / 5;
           
            Console.WriteLine("A média dos números introduzidos pelo utilizador é: {0}", resultado);


            Console.ReadKey();
            Console.Clear();

            //Exercicio 4 - receber X numero e mostrar num array

            int X;

            Console.WriteLine("Quantos números pretende introduzir?");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza os número:");

            int[] comprimento = new int[X];

            for (int i = 0; i < comprimento.Length; i++)
            {
                comprimento[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < comprimento.Length; i++)
            {
                Console.Write(comprimento[i] + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("Qual a posição do número que pretende ser mostrado?");
            int numeroArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(comprimento[numeroArray - 1]);

            Console.ReadKey();
            Console.Clear();

           




        }
    }
}
