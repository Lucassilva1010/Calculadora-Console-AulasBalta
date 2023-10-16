using System.Collections;
using System.Data;

namespace Calculadora
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Clear();

            BemVindo();
            Menu();
        }
        #region Mensagens Inicias
        static void BemVindo()
        {
            Console.WriteLine("Seja bem Vindo!");
            Console.WriteLine();

        }
        #endregion
        #region Menu Principal do Sistema
        static void Menu()
        {

            Console.WriteLine("Qual operação deseja realizar? ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Divisão ");
            Console.WriteLine("4 - Multiplicação ");
            Console.WriteLine("5 - Calcular Área ");
            Console.WriteLine("6 - Sair ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Digite a opção desejada: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {

                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: CalculaArea(); break;
                case 6: System.Environment.Exit(0); break;
                default:
                    Console.Clear();
                    Console.WriteLine($"O Opção {res} não existe no MENU.");
                    Console.WriteLine();
                    Console.WriteLine("Tente novamente!");
                    Menu();
                    break;



            }



        }
        #endregion
        #region Função soma
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 + n2;
            Console.WriteLine($"O resultado da Soma de {n1} + {n2} é: => {resultado}");
            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }
        #endregion
        #region Função de Subtração
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 - n2;
            Console.WriteLine($"O resultado da Subritação entre os numeros {n1} - {n2} é: => {resultado}");
            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }
        #endregion
        #region Função de Divisão
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 / n2;
            Console.WriteLine($"O resultado da divisão {n1} / {n2} é: => {resultado}");
            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }
        #endregion
        #region Função de Multiplicação
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 * n2;
            Console.WriteLine($"O resultado da multiplicação {n1} * {n2} é: => {resultado}");
            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }
        #endregion
        #region Função para calculo de área
        static void CalculaArea()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor da Altura: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da Largura: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 * n2;

            Console.WriteLine($"Altura: => {n1}");
            Console.WriteLine($"Largura: => {n2}");
            Console.WriteLine($"O valor da Área é: => {resultado}");
            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }
        #endregion
    }
}