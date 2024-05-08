using System;
using System.Diagnostics.Eventing.Reader;


namespace ativListaCsharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ATIVIDADE 01*/
            int quantidadeSorvetes = 15;

            double valorAPagar;
            if (quantidadeSorvetes <= 25)
            {
                valorAPagar = quantidadeSorvetes * 1.50;
            }
            else
            {
                valorAPagar = quantidadeSorvetes * 1.25;
            }

            /*ATIVIDADE 02*/
            int numero = 15;

            if (numero > 10)
            {
                int resultado = numero + 10 * 2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else
            {
                int resultado = numero + 9 * 3 - 8;
                Console.WriteLine("O resultado é: " + resultado);
            }

            /*ATIVIDADE 03*/
            int num = 6;
            if (num < 0)
            {
                Console.WriteLine("É negativo");
            }
            else
            {
                Console.WriteLine("É positivo");
            }




            /*ATIVIDADE 04*/
            int num1 = 254;
            int num2= 527;

            if (num2 > num1 ) 
            {
                Console.WriteLine("O segundo é maior");
            }   else if (num1 < num2) {

                Console.WriteLine("O primeiro não é maior que o segundo número");

            }   else{

                Console.WriteLine("os números são iguais");
            }

            /*ATIVIDADE 05*/
            double nota1 = 8;
            double nota2 = 6;


            double media = (nota1 + nota2) / 2;


            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }



        }
    }
}
