namespace PiramideAsteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;

            Console.WriteLine("Introduce un numero para generar el triangulo: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}