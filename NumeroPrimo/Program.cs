namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (Primo(numero))
            {
                Console.WriteLine($"El numero {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El numero {numero} no es primo.");
            }

            Console.ReadKey();
        }

        public static bool Primo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if((numero % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}