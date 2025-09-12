internal class Program
{
    private static void Main(string[] args)
    {
        Pr.pr p=new Pr.pr();
        Console.WriteLine("Introduzca una cadena para calcular el numeros de vocales");
        string cadena = Console.ReadLine();
        int indice =0;
        Console.WriteLine("El numero de vocales en la cadena es: " + p.ContarVocales(cadena,indice));
        Console.ReadKey();
        Console.WriteLine("Ingrese un numero para sumar sus digitos:");
        int numero = int.Parse(Console.ReadLine());
        int suma = p.sumaDigitos(numero);
        Console.WriteLine("La suma de los dígitos del número "+numero+ " es: " + suma);
        Console.ReadKey();
        Console.WriteLine("Ingrese un numero n para sumar los primeros n numeros:");
        int n = int.Parse(Console.ReadLine());
        int s = p.s(n);
        Console.WriteLine("La suma de los primeros " + n + " números es: " + s);
        Console.ReadKey();
        Console.WriteLine("Ahora se realizaran los mismos programas pero con un ciclo for");
        int contador = 0;
        for (int i = 0; i < cadena.Length; i++)
        {
            char c = cadena[i];
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                contador++;
            }
        }
        Console.WriteLine("El numero de vocales en la cadena es: " + contador);
        Console.ReadKey();
        int sumaFor = 0;
        while (numero != 0)
        {
            sumaFor += numero % 10;
            numero /= 10;
        }
        Console.WriteLine("La suma de los dígitos del número es: " + sumaFor);
        Console.ReadKey();
        int sumaN = 0;
        for (int i = 1; i <= n; i++)
        {
            sumaN += i;
        }
        Console.WriteLine("La suma de los primeros " + n + " números es: " + sumaN);
        Console.ReadKey();

    }
}