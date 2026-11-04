using MatesLib;

namespace MatesConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTRA UN NUMERO DEL 1 AL 9: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero < 1 || numero > 9)
            {
                Console.WriteLine("EL NUMERO QUE HAS ENTRAT NO ES CORRECTE.");
                Console.Write("ENTRA UN NUMERO DEL 1 AL 9: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Mates.TaulaMultiplicar(numero);
        }
    }
}
