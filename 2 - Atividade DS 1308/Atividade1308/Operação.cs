   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1308
{
    class Operação
    {
        public int res;
        public int a;
        public int b;
        public int escolha;

        public string menu()
        {
            string i;
            Console.WriteLine("Atividade Dia 13/08/2019 - Por: Bruno da Silva Costa - 2º DS");
            Console.WriteLine("Digite o número referente a operação desejada:");
            Console.WriteLine("");
            Console.WriteLine("1: Soma");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Multiplicação");
            Console.WriteLine("4: Divisão");
            Console.WriteLine("");
            Console.WriteLine("Digite 'Q' para sair.");
            Console.WriteLine("");
            i = Console.ReadLine();
            return i;
        }
        public void obtern()
        {
            a = int.Parse(Console.ReadLine());
            switch(escolha)
            {
                case 1:
                    Console.WriteLine("+");
                    break;
                case 2:
                    Console.WriteLine("-");
                    break;
                case 3:
                    Console.WriteLine("*");
                    break;
                case 4:
                    Console.WriteLine("/");
                    break;
            }
            b = int.Parse(Console.ReadLine());
        }
        public void soma()
        {
            res = a + b;
        }
        public void subtracao()
        {
            res = a - b;
        }
        public void multiplicacao()
        {
            res = a * b;
        }
        public void divisao()
        {
            res = a / b;
        }
        public void resultado()
        {
            Console.WriteLine("Resposta é de: {0}",res);
            Console.ReadKey();
            Console.Clear();
        }
    }
}