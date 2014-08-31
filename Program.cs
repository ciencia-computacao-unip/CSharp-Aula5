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

            Console.ReadKey();
        }
    }
}
