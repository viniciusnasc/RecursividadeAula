using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadeAula
{
    internal class Recursivo
    {
        public void Executar(string mensagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }

        public void ExecutarRecursivamente(string mensagem, int n)
        {
            Console.WriteLine(mensagem);
            ExecutarRecursivamente(mensagem, n-1);
        }

        public int Fatorial(int n)
        {
            if(n == 0)
                return 1;

            return n * Fatorial(n - 1);
        }
    }
}
