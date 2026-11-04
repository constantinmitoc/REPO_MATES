namespace MatesLib
{
    public class Mates
    {
        /// <summary>
        /// Mostra per pantalla la taula de multiplicar de n (de l'1 al 10)
        /// </summary>
        /// <param name="n">Número de la taula de multiplicar</param>
        public static void TaulaMultiplicar(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        /// <summary>
        /// Suma tots els nombres de l'1 fins a n
        /// </summary>
        /// <param name="n">El valor a sumar</param>
        /// <returns>Retorna la suma de 1 a n</returns>
        public static int SumaFins(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }
    }
}
