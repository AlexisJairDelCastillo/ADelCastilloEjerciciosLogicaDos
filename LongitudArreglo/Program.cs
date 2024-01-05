namespace LongitudArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tamaño;

            Console.WriteLine("Introduce un numero para determinar el tamaño de tu arreglo: ");
            tamaño = Console.ReadLine();

            int.TryParse(tamaño, out int tamañoArreglo);
            int[] arreglo = new int[tamañoArreglo];

            Console.WriteLine("Introduce los valores del arreglo, solo puedes introducir numeros que esten dentro del rango del tamaño y 1 mas.");

            ValoresArreglo(arreglo, tamañoArreglo);
            NumeroFaltante(arreglo, tamañoArreglo);

            Console.ReadKey();
        }

        public static void ValoresArreglo(int[] arreglo, int tamañoArreglo)
        {
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Introduce el valor: {i + 1}");

                if(int.TryParse(Console.ReadLine(), out int valor) && valor >= 1 && valor <= tamañoArreglo + 1)
                {
                    arreglo[i] = valor;
                }
            }
        }

        public static void NumeroFaltante(int[] arreglo, int tamanoArreglo)
        {
            var numeroFaltante = Enumerable.Range(1, tamanoArreglo + 1).Except(arreglo);
            Console.WriteLine($"El numero faltante en el arreglo es: {string.Join(" ", numeroFaltante)}");
        }
    }
}