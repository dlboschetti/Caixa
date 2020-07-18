using System;

namespace Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor que deseja Sacar:");
            int valor = Convert.ToInt32(Console.ReadLine());

            

            int nota100 = 0;
            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;
            int nota2 = 0;

            int saldo = valor;

            while (saldo >= 0)
            {
                if ((saldo - 100) >= 0)
                {
                    nota100 +=1;
                    saldo -=  100;
                }
                else
                {
                    if ((saldo - 50) >= 0)
                    {
                        nota50 +=1;
                        saldo -= 50;
                    }
                    else
                    {
                        if ((saldo - 20) >= 0)
                        {
                            nota20 += 1;
                            saldo -= 20;
                        }
                        else
                        {
                            if ((saldo - 10) >= 0)
                            {
                                nota10 += 1;
                                saldo -= 10;
                            }
                            else
                            {
                                if ((saldo - 5) >= 0)
                                {
                                    nota5 += 1;
                                    saldo -= 5;
                                }
                                else
                                {
                                    if ((saldo - 2) >= 0)
                                    {
                                        nota2 += 1;
                                        saldo -= 2;
                                    }
                                    else
                                    {
                                        if (saldo < 2)
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }

            }


            if (nota100>0) Console.WriteLine($"{nota100} nota de R$ 100,00");
            if (nota50 > 0) Console.WriteLine($"{nota50} nota de R$ 50,00");
            if (nota20 > 0) Console.WriteLine($"{nota20} nota de R$ 20,00");
            if (nota10 > 0) Console.WriteLine($"{nota10} nota de R$ 10,00");
            if (nota5 > 0) Console.WriteLine($"{nota5} nota de R$ 5,00");
            if (nota2 > 0) Console.WriteLine($"{nota2} nota de R$ 2,00");
            
        }
    }
}
