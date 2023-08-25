using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_UNICORNIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.Write("Digite seu nome completo: ",nome);
            nome = Console.ReadLine();

             char primeira = nome[0];

            Console.WriteLine("Sua primeira caracter é: {0}", primeira);

            char ultima = nome[nome.Length -1];
            Console.WriteLine("Seu ultimo caracter é: {0}", ultima);

            string tresPrimeirasLetras = nome.Substring(0, Math.Min(3, nome.Length));
            Console.WriteLine("Seus três primeiros caracteres são: {0}", tresPrimeirasLetras);

            char quarta = nome[3];
            Console.WriteLine("O quarto caracter é: {0}", quarta);

            string TodasMenosaPrimeira = nome.Substring(1);
            Console.WriteLine("Todas menos o primeiro caracter: {0}", TodasMenosaPrimeira);
            
            string doisUltimos = nome.Substring(nome.Length -2);
            Console.WriteLine("Os dois ultimos caracteres: {0}", doisUltimos);

            Console.ReadLine();

        }
    }
}
