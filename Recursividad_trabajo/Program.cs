public class Program
{
    public static void Main(string[] args)
    {
        RC.Recursividad r = new RC.Recursividad();
        Console.WriteLine("Recursividad");
        Console.WriteLine("Ingrese un numero para calcular su factorial:"); 
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("El factorial de " + num + " es: " + r.factorial(num));
        Console.ReadKey();
        Console.WriteLine("Ingrese una posicion de la sumatoria de fibonacci");
        int pos = int.Parse(Console.ReadLine());
        int posicion = pos - 1;
        Console.WriteLine("El numero en la posicion " + pos + " de la serie fibonacci es: " + r.fibonacci(posicion));
        Console.ReadKey();
        Console.WriteLine("Deme un numero a revertir");
        string numero = Console.ReadLine();
        Console.WriteLine("El numero revertido es: " + r.revertir(numero));
        Console.ReadKey();
        Console.WriteLine("Ingrese el caracter de inicio del abecedario");
        char inicio= char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el caracter final del abecedario");
        char final= char.Parse(Console.ReadLine());
        Console.WriteLine("El abecedario desde " + inicio + " hasta " + final + " es:"+r.abecedario(inicio,final));
        Console.ReadKey();






    }
}