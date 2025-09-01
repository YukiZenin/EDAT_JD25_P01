internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese solo tres numeros para saber cual es el mayor");
        Console.WriteLine("Ingrese el primer numero");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero");
        int n3 = int.Parse(Console.ReadLine());
        Func<int, int, int, int> mayor = (n1, n2, n3) =>
        {
            int max = n1;
            if (n2 > max)
            {
                max = n2;
            }
                
            if (n3 > max)
            {
                max = n3;
            }
                
            return max;
        };
        int max = mayor(n1, n2, n3);
        Console.WriteLine("Los numeros ingresados fueron: " + n1 + " " + n2 + " " + n3);
        Console.WriteLine("Y el mayor es: " + max);
        Console.ReadKey();
    }
}