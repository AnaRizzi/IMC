using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Seq
{
    class Program
    {
        static double peso, altura, imc;
        static char sexo, continua;

        static void Main(string[] args)
        {
            Console.WriteLine("Este programa irá calcular o IMC");
            do
            {
                Entrada();

                imc = Calculo_imc(peso, altura);

                if (sexo == 'm' || sexo == 'M')
                {
                    faixas_m(imc);
                }
                else
                {
                    faixas_f(imc);
                }

                pesoIdeal(sexo, altura);

                Console.WriteLine("\nDigite S para executar novamente o programa ou qualquer outra tecla para encerrar: ");
                continua = Console.ReadKey().KeyChar;
            } while (continua == 's' || continua == 'S');

        }

        static void Entrada()
        {
            Console.Write("\nDigite seu peso: ");
            while (!double.TryParse(Console.ReadLine(), out peso) || (peso <= 0))
                Console.Write("digite seu peso: ");
            Console.Write("digite sua altura em metros: ");
            while (!double.TryParse(Console.ReadLine(), out altura) || (altura <= 0))
                Console.Write("digite sua altura: ");
            Console.Write("digite seu sexo (M/F): ");
            while (!char.TryParse(Console.ReadLine(), out sexo) || ((sexo != 'm') && (sexo != 'M') && (sexo != 'f') && (sexo != 'F')))
                Console.Write("digite seu sexo (digite apenas M ou F): ");
        }


        static double Calculo_imc(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            return imc;
        }

        static void faixas_m(double imc)
        {
            if (imc < 20.7)
            {
                Console.WriteLine("A pessoa do sexo masculino possui imc de {0:N2} e está abaixo do peso ideal.", imc);
            }
            else
            {
                if (imc <= 26.4)
                {
                    Console.WriteLine("A pessoa do sexo masculino possui imc de {0:N2} e está no peso ideal.", imc);
                }
                else
                {
                    if (imc <= 31.1)
                    {
                        Console.WriteLine("A pessoa do sexo masculino possui imc de {0:N2} e está acima do peso ideal.", imc);
                    }
                    else
                    {
                        Console.WriteLine("A pessoa do sexo masculino possui imc de {0:N2} e está muito acima do peso ideal.", imc);
                    }
                }
            }
        }

        static void faixas_f(double imc)
        {
            if (imc < 19.1)
            {
                Console.WriteLine("A pessoa do sexo feminino possui imc de {0:N2} e está abaixo do peso ideal.", imc);
            }
            else
            {
                if (imc <= 25.8)
                {
                    Console.WriteLine("A pessoa do sexo feminino possui imc de {0:N2} e está no peso ideal.", imc);
                }
                else
                {
                    if (imc <= 32.3)
                    {
                        Console.WriteLine("A pessoa do sexo feminino possui imc de {0:N2} e está acima do peso ideal.", imc);
                    }
                    else
                    {
                        Console.WriteLine("A pessoa do sexo feminino possui imc de {0:N2} e está muito acima do peso ideal.", imc);
                    }
                }
            }
        }

        static void pesoIdeal(char sexo, double altura)
        {
            double pesoMin, pesoMax;
            if (sexo == 'F' || sexo == 'f')
            {
                pesoMin = 19.1 * Math.Pow(altura, 2);
                pesoMax = 25.8 * Math.Pow(altura, 2);
                Console.WriteLine("Peso mínimo ideal: {0:N2}\nPeso máximo ideal: {1:N2}", pesoMin, pesoMax);
            }
            else
            {
                pesoMin = 20.7 * Math.Pow(altura, 2);
                pesoMax = 26.4 * Math.Pow(altura, 2);
                Console.WriteLine("Peso mínimo ideal: {0:N2}\nPeso máximo ideal: {1:N2}", pesoMin, pesoMax);
            }

        }
    }
}