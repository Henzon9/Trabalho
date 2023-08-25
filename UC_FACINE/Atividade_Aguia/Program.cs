using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Aguia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1 Águia

            int i_nmr = 0, i_nmr1 = 0, i_nmr2 = 0, i_nmr3 = 0, i_nmr4 = 0, i_nmr5 = 0, i_nmr6 = 0, i_nmr7 = 0, i_nmr8 = 0, i_nmr9 = 0, i_nmr10 = 0;

            Console.Write("O numero que será mutiplicado 10 vezes: ");
            i_nmr = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} X 1 = {1}", i_nmr, i_nmr * 1);
            Console.WriteLine("{0} X 2 = {1}", i_nmr, i_nmr * 2);
            Console.WriteLine("{0} X 3 = {1}", i_nmr, i_nmr * 3);
            Console.WriteLine("{0} X 4 = {1}", i_nmr, i_nmr * 4);
            Console.WriteLine("{0} X 5 = {1}", i_nmr, i_nmr * 5);
            Console.WriteLine("{0} X 6 = {1}", i_nmr, i_nmr * 6);
            Console.WriteLine("{0} X 7 = {1}", i_nmr, i_nmr * 7);
            Console.WriteLine("{0} X 8 = {1}", i_nmr, i_nmr * 8);
            Console.WriteLine("{0} X 9 = {1}", i_nmr, i_nmr * 9);
            Console.WriteLine("{0} X 10 = {1}", i_nmr, i_nmr * 10);
            Console.ReadLine();

            //Exercicio 2 Águia

            double d_quant = 0;
            Console.Write("Digite a quantidade de Laudas: ");
            d_quant = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("A quantidade multiplicada por R$50.00: {0}", d_quant * 50);
            double d_total = d_quant * 50;
            Console.WriteLine("\n");
            Console.WriteLine("Quantidade parcelada em 3 vezes iguais: {0}", (d_total / 3));
            Console.WriteLine("\n");
            Console.ReadLine();

            //Exercicio 3 Águia

            string s_nome = "";
            Console.Write("Digite seu nome: ");
            s_nome = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Bem vindo {0}, tenha um otimo dia, que hoje seu dia seja abençoado, AMÉM irmãos", s_nome);
            Console.Write("\n");
            Console.WriteLine("Tecle ENTER para finalizar");
            Console.ReadLine();

        }
    }
}
