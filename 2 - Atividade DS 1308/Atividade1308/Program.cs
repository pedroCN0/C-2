using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1308
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
            int ss;
            Operação A;
            A = new Operação();
            i = "0";
            while (i != "Q" && i != "q")
            {
                i = A.menu();
                Console.Clear();
                if (i != "Q" && i != "q")
                {
                    if (i != "Q" && i != "q")
                    {
                        ss = int.Parse(i);
                        A.escolha = int.Parse(i);
                        if (ss >= 1 && ss <= 4)
                        {
                            switch (i)
                            {
                                case "1":
                                    Console.WriteLine("Operação escolhida: Soma.");
                                    Console.WriteLine("Digite os 2 números da operação:");
                                    A.obtern();
                                    A.soma();
                                    A.resultado();
                                    break;
                                case "2":
                                    Console.WriteLine("Operação escolhida: Subtração.");
                                    Console.WriteLine("Digite os 2 números da operação:");
                                    A.obtern();
                                    A.subtracao();
                                    A.resultado();
                                    break;
                                case "3":
                                    Console.WriteLine("Operação escolhida: Multiplicação.");
                                    Console.WriteLine("Digite os 2 números da operação:");
                                    A.obtern();
                                    A.multiplicacao();
                                    A.resultado();
                                    break;
                                case "4":
                                    Console.WriteLine("Operação escolhida: Divisão.");
                                    Console.WriteLine("Digite os 2 números da operação:");
                                    A.obtern();
                                    A.divisao();
                                    A.resultado();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Erro: Número não detectado.");
                        Console.WriteLine("");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}