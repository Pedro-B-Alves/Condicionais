﻿using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui vai o código do nosso programa
            // C# é uma linguagem case sensitive

            //Declarar as variaveis
            float nota1, nota2, nota3, media;
            string nomeCompleto;

            //Entrada de dados
            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //Processamento
            media = (nota1+nota2+nota3)/3;

            //Exibir o resultado
            if(media>5){
                //Valor verdadeiro
                Console.WriteLine("O Aluno "+nomeCompleto+" está aprovado com a média de: "+media);
            }else{
                //Valor Falso
                Console.WriteLine("O Aluno "+nomeCompleto+" está REPROVADO com a média de: "+media);
            }
        }
    }
}
