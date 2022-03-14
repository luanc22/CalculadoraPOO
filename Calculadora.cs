using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    public class Calculadora
    {
        public double primeiroNumero;
        public double segundoNumero;
        public int operacaoEscolhida;
        public double resultadoConta;

        public double Calcular()
        {
            switch (operacaoEscolhida)
            {
                case 1:
                    resultadoConta = primeiroNumero + segundoNumero;
                    return resultadoConta;
                case 2:
                    resultadoConta = primeiroNumero - segundoNumero;
                    return resultadoConta;
                case 3:
                    resultadoConta = primeiroNumero * segundoNumero;
                    return resultadoConta;
                case 4:
                    resultadoConta = primeiroNumero / segundoNumero;
                    return resultadoConta;
                case 5:
                    resultadoConta = primeiroNumero % segundoNumero;
                    return resultadoConta;
            }

            return resultadoConta;
        }

        public void EscolherConta()
        {
            switch (operacaoEscolhida)
            {
                case 1:
                    Console.WriteLine("===========================");
                    Console.WriteLine("Voce escolheu a opcao somar.");
                    Console.WriteLine();
                    Console.WriteLine("Seu resultado eh: " + Math.Round(Calcular(), 2));
                    Console.WriteLine("===========================");
                    break;
                case 2:
                    Console.WriteLine("===========================");
                    Console.WriteLine("Voce escolheu a opcao subtrair.");
                    Console.WriteLine();
                    Console.WriteLine("Seu resultado eh: " + Math.Round(Calcular(), 2));
                    Console.WriteLine("===========================");
                    break;
                case 3:
                    Console.WriteLine("===========================");
                    Console.WriteLine("Voce escolheu a opcao multiplicar.");
                    Console.WriteLine();
                    Console.WriteLine("Seu resultado eh: " + Math.Round(Calcular(), 2));
                    Console.WriteLine("===========================");
                    break;
                case 4:
                    if (primeiroNumero == 0)
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                        Console.WriteLine("AVISO!");
                        Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                        resultadoConta = 0;
                        Console.WriteLine("");
                        Console.WriteLine("Seu resultado eh: " + Math.Round(resultadoConta, 2));
                        Console.WriteLine("===========================");
                    }
                    else if (segundoNumero == 0)
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                        Console.WriteLine("AVISO!");
                        Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                        resultadoConta = 0;
                        Console.WriteLine("");
                        Console.WriteLine("Seu resultado eh: " + Math.Round(resultadoConta, 2));
                        Console.WriteLine("===========================");
                    }
                    else
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                        Console.WriteLine();
                        Console.WriteLine("Seu resultado eh: " + Math.Round(Calcular(), 2));
                        Console.WriteLine("===========================");
                    }
                    break;
                case 5:
                    if (primeiroNumero == 0)
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                        Console.WriteLine("AVISO!");
                        Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                        resultadoConta = 0;
                        Console.WriteLine("");
                        Console.WriteLine("Seu resultado eh: " + Math.Round(resultadoConta, 2));
                        Console.WriteLine("===========================");
                    }
                    else if (segundoNumero == 0)
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                        Console.WriteLine("AVISO!");
                        Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                        resultadoConta = 0;
                        Console.WriteLine("");
                        Console.WriteLine("Seu resultado eh: " + Math.Round(resultadoConta, 2));
                        Console.WriteLine("===========================");
                    }
                    else
                    {
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao de dividir por resto.");
                        Console.WriteLine("AVISO!");
                        Console.WriteLine("Esta opcao mostra o resto da operacao, e nao o seu valor.");
                        Console.WriteLine();
                        Console.WriteLine("Seu resultado eh: " + Math.Round(Calcular(), 2));
                        Console.WriteLine("===========================");
                    }
                    break;

                default:
                    Console.WriteLine("===========================");
                    Console.WriteLine("Por favor, selecione uma opcao valida.");
                    break;
            }
        }

    }
}
