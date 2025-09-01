internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese cuantos numeros desea");
        int num=int.Parse(Console.ReadLine());
        var numeros = new List<int>();
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Ingrese el numero de la posicion: "+(i+1));
            int n=int.Parse(Console.ReadLine());
            numeros.Add(n);
        }
        Func<List<int>, float> promedio = lista =>
        {
            if (lista.Count > 0)
                return lista.Sum() / (float)lista.Count;
            else
                return 0;
        };
        float pro = promedio(numeros);
        Console.WriteLine("Los numeros ingresados fueron: ");
        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Y el promedio es: "+pro);
        Console.ReadKey();
    }
}