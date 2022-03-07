using System;

namespace OrdenaVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[5];
            Random random = new Random();

            for(int i = 0; i < valor.Length; i++)
            {
                valor[i] = random.Next(6);
            }

            int buscar = 5; // valor que ele procura

            bool achei = false; //vou iniciar a busca do elemento no vetor

            for(int i = 0;i < valor.Length; i++)
            {
                if(buscar == valor[i])
                {
                    Console.WriteLine("Encontrei o valor: {0}, na posição: {1}",valor[i],i);
                    achei = true;
                }
            }

            if(!achei)
            {
                Console.WriteLine("Valor não localizado!");
            }
                        
        }
    }
}
