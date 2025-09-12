public class Program
{
    public static void Main(string[] args)
    {
        // Crear instancia de la clase que contiene los métodos recursivos
        RC.Recursividad r = new RC.Recursividad();
        Console.WriteLine("Recursividad");
        // ==================== FACTORIAL RECURSIVO ====================
        Console.WriteLine("Ingrese un numero para calcular su factorial:"); 
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("El factorial de " + num + " es: " + r.factorial(num));
        Console.ReadKey();
        // ==================== FIBONACCI RECURSIVO ====================
        Console.WriteLine("Ingrese una posicion de la sumatoria de fibonacci");
        int pos = int.Parse(Console.ReadLine());
        int posicion = pos - 1;
        Console.WriteLine("El numero en la posicion " + pos + " de la serie fibonacci es: " + r.fibonacci(posicion));
        Console.ReadKey();
        // ==================== REVERSIÓN DE CADENA RECURSIVA ====================
        Console.WriteLine("Deme un numero a revertir");
        string numero = Console.ReadLine();
        Console.WriteLine("El numero revertido es: " + r.revertir(numero));
        Console.ReadKey();
        // ==================== ABECEDARIO RECURSIVO ====================
        Console.WriteLine("Ingrese el caracter de inicio del abecedario");
        char inicio= char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el caracter final del abecedario");
        char final= char.Parse(Console.ReadLine());
        Console.WriteLine("El abecedario desde " + inicio + " hasta " + final + " es:"+r.abecedario(inicio,final));
        Console.ReadKey();
        // ==================== CICLOS FOR ====================
        Console.WriteLine("Ahora se realizaran los mismos programas con un ciclo for");
        // ==================== FACTORIAL CON FOR ====================
        int factorialFor = 1;
        for (int i = 1; i <= num; i++)
        {
            factorialFor *= i;
        }
        Console.WriteLine("El factorial de " + num + " es: " + factorialFor);
        Console.ReadKey();
        // ==================== FIBONACCI CON FOR ====================
        int a = 0, b = 1, fiboFor = 0;
        if (posicion == 0)
        {
            fiboFor = 0;
        }
        else if (posicion == 1)
        {
            fiboFor = 1;
        }
        else
        {
            for (int i = 2; i <= posicion; i++)
            {
                fiboFor = a + b;
                a = b;
                b = fiboFor;
            }
        }
        Console.WriteLine("El numero en la posicion " + pos + " de la serie fibonacci es: " + fiboFor);
        Console.ReadKey();
        // ==================== REVERSIÓN DE CADENA CON FOR ====================
        char[] charArray = numero.ToCharArray();
        Array.Reverse(charArray);
        string numeroRevertido = new string(charArray);
        Console.WriteLine("El numero revertido es: " + numeroRevertido);
        Console.ReadKey();
        // ==================== ABECEDARIO CON FOR ====================
        Console.Write("El abecedario desde " + inicio + " hasta " + final + " es: ");
        for (char c = inicio; c <= final; c++)
        {
            Console.Write(c + " ");
        }
        Console.ReadKey();
    }
}