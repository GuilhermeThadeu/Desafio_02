using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1   = 33;
            double peso1 = 88.50;
            decimal altura1 = 1.65M;
            bool EhDev1  = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;


            //T1 - Somar a idade de todos Ubuntus
            int c = idade1 + idade2 + idade3;
            Console.WriteLine($"idade total dos Ubuntus: {c} anos ");
            Console.WriteLine();
            //T2 - Agrupar os nomes de todos Ubuntus
             Console.WriteLine($"Todos os nomes dos Ubuntus:\n {nome1}\n {nome2}\n {nome3}\n ");
            //T3 - Calcular Média dos IMC de todos Ubuntus
            var imcaltura1 = Convert.ToInt32(altura1);
            var imcpeso1 = Convert.ToInt32(peso1);
            var imc1 = imcpeso1 / (imcaltura1 * imcaltura1);
            Console.WriteLine($"media de IMC do {nome1}: {imc1}");

            var imcaltura2 = Convert.ToInt32(altura2);
            var imcpeso2 = Convert.ToInt32(peso2);
            var imc2 = imcpeso1 / (imcaltura2 * imcaltura2);
            Console.WriteLine($"media de IMC do {nome2}: {imc2}");

            var imcaltura3 = Convert.ToInt32(altura3);
            var imcpeso3 = Convert.ToInt32(peso3);
            var imc3 = imcpeso3 / (imcaltura3 * imcaltura3);
            Console.WriteLine($"media de IMC do {nome1}: {imc3}");
            Console.WriteLine();
            //T4 - Contar quantos Ubuntus sao Devs
            int devcount = 0;
            if (EhDev1 == true)
            {
                devcount++;
            }

            if   (EhDev2 == true)
            {
                devcount++;
            }
          
            if (EhDev3 == true)
            {
                devcount++;
            }

            Console.WriteLine($"quantidade de ubuntu que sao devs: {devcount}");

            Console.WriteLine();

            //T5 - Exibir somente Ubuntu com nome Silva
            string[] vetnome;
            vetnome = nome1.Split(" ");
            if (vetnome[1] == "Silva")
            {
                Console.WriteLine(nome1);
            }
            vetnome = nome2.Split(" ");
            if (vetnome[1] == "Silva")
            {
                Console.WriteLine(nome2);
            }
            vetnome = nome3.Split(" ");
            if (vetnome[1] == "Silva")
            {
                Console.WriteLine(nome3);
            }

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }


    }
}
