﻿using System;
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
			
			Console.WriteLine("\n\n\n");
			
            //início exercício 3
            Console.WriteLine("3) Escreva um programa que calcule o fatorial de um número informado pelo usuário.\nExemplo: 4! = 1 * 2 * 3 * 4 = 24, portanto o fatorial de 4 é igual a 24.\n");
            Console.Write("Digite um número: ");
            int um_numero=0,um_resultado=1;
            um_numero = int.Parse(Console.ReadLine());
            Console.Write("\n{0}!=1",um_numero);
            for (int x = 2; x <= um_numero; x++){
                um_resultado = um_resultado * x;
                Console.Write("*{0}", x);
            }
            Console.WriteLine("={0}", um_resultado);
            //fim exercício 3

            Console.WriteLine("\n\n\n");

            //início exercício 4
            Console.WriteLine("4) Escreva um programa que exiba na tela a quantidade de números ímpares existentes entre dois números que o usuário digitar (testar inclusive os números digitados).\n");
            Console.Write("Digite um número: ");
            int primeiro_numero,segundo_numero,quantidade_numeros_impares=0,menor_numero,maior_numero;
            primeiro_numero = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            segundo_numero = int.Parse(Console.ReadLine());
            if (primeiro_numero <= segundo_numero){
                menor_numero = primeiro_numero;
                maior_numero = segundo_numero;
            }else{
                menor_numero = segundo_numero;
                maior_numero = primeiro_numero;
            }
            for (int x = menor_numero; x <= maior_numero; x++){
                if (x % 2 != 0) { quantidade_numeros_impares++; }
            }
            Console.WriteLine("Quantidade de números ímpares entre {0} e {1} é {2}",menor_numero,maior_numero,quantidade_numeros_impares);
            //fim exercício 4

            Console.WriteLine("\n\n\n");

            //início exercício 5
            Console.WriteLine("5) Escreva um programa que leia 15 números inteiros e exiba na tela ao final, o maior número que foi digitado pelo usuário.\n");
            int numeros_ex5, maior_numero_ex5=0;
            for (int x = 1; x <= 15; x++){
                Console.Write("Digite o {0}° número: ",x);
                numeros_ex5 = int.Parse(Console.ReadLine());
                if (numeros_ex5 > maior_numero_ex5){
                    maior_numero_ex5 = numeros_ex5;
                }
            }
            Console.WriteLine("\nO maior número digitado foi: {0}", maior_numero_ex5);
            //fim exercício 5


            Console.ReadKey();
        }
    }
}
