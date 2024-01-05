namespace MinimoComunMultiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            int mcm = 1;

            Console.WriteLine("Introduce el primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            for(int i  = 2; i <= numero1 || i <= numero2; i++)
            {
                while ((i <= numero1 && numero1 % i == 0) || (i <= numero2 && numero2 % i == 0))
                {
                    mcm *= i;

                    if(i <= numero1 && numero1 % i == 0)
                        numero1 /= i;
                    if(i <= numero2 && numero2 % i == 0)
                        numero2 /= i;
                }
            }

            Console.WriteLine($"El Minimo Comun Multiplo es: {mcm}");

            Console.ReadKey();
        }
    }
}