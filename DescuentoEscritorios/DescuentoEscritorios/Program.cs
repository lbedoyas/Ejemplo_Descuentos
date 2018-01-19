using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescuentoEscritorios
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEscritorios;
            decimal valorApagar;
            PedirDatos(out numeroEscritorios);
            valorApagar = CalcularValor(numeroEscritorios);
            MostrarResultados(valorApagar);
        }

        static void PedirDatos(out int numeroEscritorios)
        {
            Console.Write("Ingrese numero de escritorios: ...  ");
            numeroEscritorios = Convert.ToInt32(Console.ReadLine());

        }

        static decimal CalcularValor(int numeroEscritorios)
        {
            decimal valor = numeroEscritorios * 650000;
            if (numeroEscritorios < 5) return valor * 0.9M;
            if (numeroEscritorios < 10) return valor * 0.8M;
            return valor * 0.6M;
            
        }

        static void MostrarResultados(decimal valorApagar)
        {
            Console.WriteLine("El valor a pagar es: ${0:N0}",valorApagar);
            Console.ReadKey();
        }
    }
}
