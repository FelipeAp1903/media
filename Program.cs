using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felipe_jog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nota = new int[10];
            double media, soma = 0, quantidade = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite  {0}° número inteiro", (i + 1));
                nota[i] = int.Parse(Console.ReadLine());
                soma += nota[i];
            }
            media = soma / 10;
            for (int i = 0; i < 10; i++)
            {
                if (nota[i] > media)
                    quantidade++;
            }
            Console.Clear();
            Console.WriteLine("O valor da média é: {0}", media);
            if (quantidade == 0)
                Console.WriteLine("Não existe nenhum número maior que a média");
            else
                Console.WriteLine("Existe {0} numero(s) maior(es) que a média", quantidade);
            Console.ReadLine();
        }
    }
}
