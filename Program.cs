using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaAmizadeVersaoConrado200623
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontos = 0;

            Console.WriteLine("Bem-Vindo ao jogo do 21");
            Console.WriteLine("Faça 21 pontos para vencer");

            while (true)
            {

                Console.WriteLine($"Você tem {pontos} pontos");
                Console.WriteLine("Digite 1 para continuar ou 2 para parar:");
                int resposta = Int32.Parse(Console.ReadLine());

                if (resposta == 2)
                {
                    Console.WriteLine("Fim de jogo");
                    break;
                }


                Random random = new Random();
                int numero = random.Next(1, 11);
                Console.WriteLine($"Você tirou o numero {numero}");

                pontos += numero;

                if (pontos > 21)
                {
                    Console.Clear(); //apaga o restante
                    Console.WriteLine("Você perdeu");
                    break; // Volta para o while
                }


            }

            Console.ReadKey();

        }
    }
}
