using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizDe20
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

			try
			{

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i * 5;
                }
                Console.WriteLine("el elemento array: ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"el elemento {i}: {array[i]}");
                }


            }
            catch (Exception)
			{
                Console.WriteLine("error: presione cualquier tecla para salir. ");
			
			}
        }
    }
}
