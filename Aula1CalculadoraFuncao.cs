using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1CalculadoraFuncao
{
    internal class Aula1CalculadoraFuncao
    {

        static void Main(string[] args)
        {
            bool fecharCalc = false;
            var listaHistorico = new List<string>();

            while (fecharCalc != true)
            {

                Console.WriteLine("== Bem vindo a calculadora ==");
                Console.WriteLine("");
                Console.Write("Coloque o primeiro numero: ");
                string inputClcOne = Console.ReadLine();
                float inputClcNumOne = float.Parse(inputClcOne);
                Console.Write("Coloque o segundo numero: ");
                string inputClcTwo = Console.ReadLine();
                float inputClcNumTwo = float.Parse(inputClcTwo);
                float resultado = 0.0f;

                Console.WriteLine("");
                Console.WriteLine("Selecione a funcao que deseja realizar na calculadora:");
                Console.WriteLine("1 - Somar.\n2 - Subtrair.\n3 - Multiplicar.\n4 - Dividir por valor.\n5 - Dividir por resto.\n0 - Para fechar.");
                Console.WriteLine("");

                Console.Write("Opcao escolhida: ");
                string contStr = Console.ReadLine();
                int cont = 0;

                if (contStr == "1" || contStr == "2" || contStr == "3" || contStr == "4" || contStr == "5")
                {
                    cont = int.Parse(contStr);
                }
                else if (contStr == "0")
                {
                    break;
                }

                Console.WriteLine("");


                switch (cont)
                {
                    case 1:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao somar.");
                        resultado = Calcular(inputClcNumOne, inputClcNumTwo, cont);
                        Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                        Console.WriteLine("===========================");
                        break;
                    case 2:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Voce escolheu a opcao subtrair.");
                        resultado = Calcular(inputClcNumOne, inputClcNumTwo, cont);
                        Console.WriteLine("");
                        Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                        Console.WriteLine("===========================");
                        break;
                    case 3:
                        Console.WriteLine("===========================");

                        Console.WriteLine("Voce escolheu a opcao multiplicar.");
                        resultado = Calcular(inputClcNumOne, inputClcNumTwo, cont);
                        Console.WriteLine("");
                        Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                        Console.WriteLine("===========================");
                        break;
                    case 4:
                        if (inputClcNumOne == 0)
                        {
                            Console.WriteLine("===========================");
                            Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                            Console.WriteLine("AVISO!");
                            Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                            resultado = 0;
                            Console.WriteLine("");
                            Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                            Console.WriteLine("===========================");
                        }
                        else if (inputClcNumTwo == 0)
                        {
                            Console.WriteLine("===========================");
                            Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                            Console.WriteLine("AVISO!");
                            Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                            resultado = 0;
                            Console.WriteLine("");
                            Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                            Console.WriteLine("===========================");
                        }
                        else
                        {
                            Console.WriteLine("===========================");
                            Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                            resultado = Calcular(inputClcNumOne, inputClcNumTwo, cont);
                            Console.WriteLine("");
                            Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                            Console.WriteLine("===========================");
                        }
                        break;
                    case 5:
                        if (inputClcNumOne == 0)
                        {
                            Console.WriteLine("===========================");
                            Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                            Console.WriteLine("AVISO!");
                            Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                            resultado = 0;
                            Console.WriteLine("");
                            Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                            Console.WriteLine("===========================");
                        }
                        else if (inputClcNumTwo == 0)
                        {
                            Console.WriteLine("===========================");
                            Console.WriteLine("Voce escolheu a opcao de dividir por valor.");
                            Console.WriteLine("AVISO!");
                            Console.WriteLine("Sua conta possui um 0, isso retornara um 0 em seu calculo.");
                            resultado = 0;
                            Console.WriteLine("");
                            Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                            Console.WriteLine("===========================");
                        }
                        else
                        {
                            Console.WriteLine("===========================");
                            Console.WriteLine("Voce escolheu a opcao de dividir por resto.");
                            Console.WriteLine("AVISO!");
                            Console.WriteLine("Esta opcao mostra o resto da operacao, e nao o seu valor.");
                            resultado = Calcular(inputClcNumOne, inputClcNumTwo, cont);
                            Console.WriteLine("");
                            Console.WriteLine("Seu resultado eh: " + Math.Round(resultado, 2));
                            Console.WriteLine("===========================");
                        }
                        break;
                    default:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Por favor, selecione uma opcao valida.");
                        break;
                }


                string resultadoStr;

                switch (cont)
                {
                    case 1:
                        resultadoStr = inputClcOne + "+" + inputClcTwo + " = " + resultado.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 2:
                        resultadoStr = inputClcOne + "-" + inputClcTwo + " = " + resultado.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 3:
                        resultadoStr = inputClcOne + "*" + inputClcTwo + " = " + resultado.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 4:
                        resultadoStr = inputClcOne + "/" + inputClcTwo + " = " + resultado.ToString();
                        listaHistorico.Add(resultadoStr);
                        break;
                    case 5:
                        resultadoStr = inputClcOne + "%" + inputClcTwo + " = " + resultado.ToString();
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
                        Console.WriteLine(listaHistorico[i]);
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

            }

        }

        static float Calcular(float numOne, float numTwo, int operacaoEscolhida)
        {
            switch (operacaoEscolhida)
            {
                case 1:
                    return numOne + numTwo;
                case 2:
                    return numOne - numTwo;
                case 3:
                    return numOne * numTwo;
                case 4:
                    return numOne / numTwo;
                case 5:
                    return numOne % numTwo;
            }
            return 0;
        }
    }
}
