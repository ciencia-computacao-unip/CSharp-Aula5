using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aula5{
    class Program{
        static void Main(string[] args){
            //inicio exercício 1
            Console.WriteLine("1) Escreva um programa que exiba na tela em ordem crescente, apenas os números pares existentes de 11 a 250.\n");
            for (int x = 11; x <= 250; x++){
                if (x % 2 == 0){
                    Console.WriteLine(x);
                }
            }
            //fim exercício 1

            Console.WriteLine("\n\n\n");

            //incício exercício 2
            Console.WriteLine("2) Escreva um programa que exiba na tela a tabuada de um número que deverá ser informado pelo usuário.\n");
            Console.Write("Digite um número: ");
            int numero, resultado;
            numero = int.Parse(Console.ReadLine());
            Console.Write("\n");
            for (int x = 1; x <= 10; x++){
                resultado = numero * x;
                Console.Write("{0}x{1}={2}\n",numero,x,resultado);
            }
            //fim exercício 2

            Console.ReadKey();
        }
    }
}
