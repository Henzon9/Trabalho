using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Coruja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 1\n");
            int i_nro1 = 0;
            Console.Write("Digite seu numero real:");
            i_nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu sucessor é: {0}", i_nro1 +1);
            Console.WriteLine("Seu antessor é: {0}", i_nro1 -1);
            Console.ReadLine();

           
            Console.WriteLine("\n\nAtividade 2\n");
            string s_name, s_endereço, s_telefone;
            Console.Write("Digite seu nome:");
            s_name = Console.ReadLine();
            Console.Write("Digite seu enedereço:");
            s_endereço = Console.ReadLine();
            Console.Write("Digite seu telefone:");
            s_telefone = Console.ReadLine();
            Console.WriteLine("\n nome: {0}\n Endereço: {1}\n Telefelone: {2}\n", s_name, s_endereço, s_telefone);
            Console.ReadLine();


            Console.WriteLine("\n\nAtividade 3\n");

            i_nro1 = 0;
            int i_nro2 = 0;
            Console.Write("Digite o 1° numero inteiro:");
            i_nro1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2° numero inteiro:");
            i_nro2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma é: {0}", i_nro1 + i_nro2);
            Console.WriteLine("A subtração é: {0}", i_nro1 - i_nro2);
            Console.WriteLine("A multiplicação é: {0}", i_nro1 * i_nro2);
            Console.ReadLine();


            Console.WriteLine("\n\nAtividade 4\n");

            double peso = 0, altura = 0;
            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Sua IMC será: {0}", peso / (altura * 2));
            Console.ReadLine();


        }
        
    }
}
