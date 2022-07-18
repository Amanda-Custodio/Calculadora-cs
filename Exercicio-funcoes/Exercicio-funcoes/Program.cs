using System;

namespace Exercicio_funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor1, valor2, soma, subtracao, produto, divisao, i, n;

            Console.WriteLine("Bem-vinda à Calculadora da Mallu! Aperte 1 para começar!");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {

                do
                {
                    Console.WriteLine("Digite dois números para somar, subtrair, multiplicar e dividir");
                    valor1 = int.Parse(Console.ReadLine());
                    valor2 = int.Parse(Console.ReadLine());


                    Console.WriteLine("Para os números escolhidos, os resultados são: ");
                    Console.WriteLine("Soma =" + " " + Soma(valor1, valor2));
                    Console.WriteLine("Subtração =" + " " + Subtracao(valor1, valor2));
                    Console.WriteLine("Multiplicação =" + " " + Produto(valor1, valor2));
                    Console.WriteLine("Divisão =" + " " + Divisao(valor1, valor2));

                    Console.WriteLine("Deseja continuar? Aperte 0 para prosseguir ou 2 para desligar");
                    i = int.Parse(Console.ReadLine());

                }

                while (i == 0);
            }
                
                else Console.WriteLine("Fim do programa");
            
        }
        public static int Soma(int x, int y)
        {
            return x + y;
        }
        public static int Subtracao(int x, int y)
        {
            return x - y;
        }
        public static int Produto(int x, int y)
        {
            return x * y;
        }
        public static int Divisao(int x, int y)
        {
            if (DiferenteDeZero(y)) throw new Exception("Não é permitido dividir por 0");
            return x / y;

            bool DiferenteDeZero(int y)
            {
                if (y == 0) return true;

                return false;
            }
        }

      
    }
}
