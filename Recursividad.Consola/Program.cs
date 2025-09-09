internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Recursividad");
        Console.WriteLine("Casos de recursividad:");
        Console.WriteLine("Caso 1:");
        Recursividad_Logica.Recursividad r = new Recursividad_Logica.Recursividad();
        Console.WriteLine("Ingrese un numero para calcular su factorial:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("El factorial de " + num + " es: " + r.factorial(num));
        Console.ReadKey();
        Console.WriteLine("Potencia");
        Console.WriteLine("Ingrese el numero que deseee elevar");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la potencia a la que desea elevar el numero");
        int potencia = int.Parse(Console.ReadLine());
        Console.WriteLine("El resultado de elevar " + numero + " a la potencia de " + potencia + " es: " + r.Potencia(numero, potencia));
        Console.ReadKey();
    }
}