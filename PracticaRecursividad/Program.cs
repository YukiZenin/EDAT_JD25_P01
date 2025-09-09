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
    }
}