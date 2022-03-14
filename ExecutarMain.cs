using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    internal class ExecutarMain
    {

        static void Main(string[] args)
        {
            bool fecharCalc = false;
            var listaHistorico = new List<string>();
            Calculadora calc1 = new Calculadora();

            while (fecharCalc != true)
            {
                #region Input de Dados e Menu. [OK]

                Cabecalho();

                Console.Write("Coloque o primeiro numero: ");
                string inputClcOne = Console.ReadLine();
                calc1.primeiroNumero = double.Parse(inputClcOne);
                Console.Write("Coloque o segundo numero: ");
                string inputClcTwo = Console.ReadLine();
                calc1.segundoNumero = double.Parse(inputClcTwo);
            
                Console.WriteLine();
                Console.WriteLine("Selecione a funcao que deseja realizar na calculadora:");
                Console.WriteLine();
                Console.WriteLine("1 - Somar.\n2 - Subtrair.\n3 - Multiplicar.\n4 - Dividir por valor.\n5 - Dividir por resto.\n0 - Para fechar.");
                Console.WriteLine();

                Console.Write("Opcao escolhida: ");
                string contStr = Console.ReadLine();
                int cont = 0;

                if (contStr == "1" || contStr == "2" || contStr == "3" || contStr == "4" || contStr == "5")
                {
                    cont = int.Parse(contStr);

                    switch (cont)
                    {
                        case 1:
                            calc1.operacaoEscolhida = 1;
                            break;
                        case 2:
                            calc1.operacaoEscolhida = 2;
                            break;
                        case 3:
                            calc1.operacaoEscolhida = 3;
                            break;
                        case 4:
                            calc1.operacaoEscolhida = 4;
                            break;
                        case 5:
                            calc1.operacaoEscolhida = 5;
                            break;
                    }
                }
                else if (contStr == "0")
                {
                    break;
                }

                #endregion

                #region Chamado do resultado. [OK]

                Console.WriteLine();

                calc1.EscolherConta();

                #endregion

                #region Historico. [OK]

                // estudar como passar para POO.

                string resultadoStr;

                switch (cont)
                {
                    case 1:
                        resultadoStr = inputClcOne + "+" + inputClcTwo + " = " + calc1.resultadoConta.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 2:
                        resultadoStr = inputClcOne + "-" + inputClcTwo + " = " + calc1.resultadoConta.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 3:
                        resultadoStr = inputClcOne + "*" + inputClcTwo + " = " + calc1.resultadoConta.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 4:
                        resultadoStr = inputClcOne + "/" + inputClcTwo + " = " + calc1.resultadoConta.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 5:
                        resultadoStr = inputClcOne + "%" + inputClcTwo + " = " + calc1.resultadoConta.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Conta nao realizada!");
                        Console.WriteLine("===========================");
                        break;
                }


                int tamanhoLista = listaHistorico.Count;
                int i = 0;

                Console.WriteLine("");
                Console.WriteLine("Caso deseje fazer outra conta, digite 1.");
                Console.WriteLine("Caso deseje fechar a calculadora, digite 2.");
                Console.WriteLine("Caso deseje ver o historico de operacoes, digite 3.");
                Console.WriteLine("");
                Console.Write("Opcao escolhida: ");
                int botaoFechar = int.Parse(Console.ReadLine());

                if (botaoFechar == 2)
                {
                    fecharCalc = true;
                }
                else if (botaoFechar == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ultimas operacoes: ");
                    while (tamanhoLista > i)
                    {
                        if (listaHistorico[i].Contains("+"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(listaHistorico[i]);
                            Console.ResetColor();

                        }
                        else if (listaHistorico[i].Contains("-"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(listaHistorico[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(listaHistorico[i]);
                        }

                        i++;

                        if (i > 10)
                        {
                            break;
                        }
                    }


                }

                Console.WriteLine("");
                Console.WriteLine("Aperte ENTER para prosseguir.");
                Console.ReadLine();
                Console.Clear();

                #endregion

            }
        }

        static void Cabecalho()
        {
            Console.WriteLine("=============== Calculadora ===============");
            Console.WriteLine();
            Console.WriteLine("Bem vindo a calculadora, utilize-a para calcular dois numeros.");
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine();
        }

       
    }
}
