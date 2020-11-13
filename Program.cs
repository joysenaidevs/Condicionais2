using System;

namespace Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a sua idade");
            int idade = int.Parse(Console.ReadLine());

            //bool resposta = true; //armazenar valor se verdadeiro ou falso

             if(idade >=18){
                Console.WriteLine("Voce gostaria de participar do time Cs Go? -Sim ou Não?");
                string resposta = Console.ReadLine();
                if (resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria -Falar com a Sara");

                }else{
                    Console.WriteLine("Blz! Passar bem");
              }
            }else{
                Console.WriteLine("Voce gostaria de participar do time LOL? Sim ou Não");
                string resposta = Console.ReadLine();
                if (resposta == "Sim"){
                        Console.WriteLine("Compareça a secretaria - Falar com o Juscelino");

                }else{
                        Console.WriteLine("Muito Obrigado");
                }


            }

                

            //valor se verdadeiro
            //Console.WriteLine("Valor se verdadeiro");

            //}else{
            //Console.WriteLine("Valor se Falso");
                

            
        } //fim do main
    }
}
