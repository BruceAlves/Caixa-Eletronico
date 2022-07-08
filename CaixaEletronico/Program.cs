using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Desenvolva um programa para um caixa eletronico onde
             temos as opções de saque, deposito e ver saldo;
             */
            double saldo = 0, deposito = 0, saque;
            int  opcao = 1;

            while (opcao != 0)
            {
                Console.WriteLine("O que você deseja fazer");
                Console.WriteLine("1 - Ver saldo");
                Console.WriteLine("2 - Deposito");
                Console.WriteLine("3 - Fazer saque");
                Console.WriteLine("0 - sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Seu saldo é de {saldo.ToString("C")}");
                        break;
                    case 2:
                        Console.WriteLine("Quanto você deseja depositar ?");
                        deposito = Convert.ToDouble(Console.ReadLine());
                        saldo += deposito;
                        break;
                    case 3:
                        Console.WriteLine("Quanto você deseja sacar ?");
                        saque = Convert.ToDouble(Console.ReadLine());
                        if (saque > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                        {
                            saldo -= saque;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Operação finalizada");
                        break;
                        default: 
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            Console.ReadKey();


        }
    }
}
