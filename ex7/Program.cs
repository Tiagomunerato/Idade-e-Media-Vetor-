using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ano = new int[5];
            int somaidade = 0, idade;
            double media;

            for(int i = 0; i <= 4; i++)
            {
                Console.Write("Informe o {0}º ano de nascimento => ", i + 1);
                ano[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 4; i++)
            {
                idade = 2019 - ano[i];
                somaidade = somaidade + idade;
                Console.WriteLine("Idade do {0}ª pessoa => {1}",i + 1, idade);

                //Console.WriteLine("idade => {0}", (2019 - ano[i]));
                //somaidade = somaidade + (2019 - ano[i]);
            }
            media = (double) somaidade / 5;
            Console.WriteLine("Média das idades => {0:N1}", media);
            Console.ReadKey();
        }
    }
}
