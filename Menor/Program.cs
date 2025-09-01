internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cuantos numeros desea ingresar?");
        int num = int.Parse(Console.ReadLine());    
        var numeros = new List<int>();
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Ingrese el numero de la posicion: " + (i + 1));
            int n = int.Parse(Console.ReadLine());
            numeros.Add(n);
        }
        Func<List<int>, int> menor = lista =>
        {
            if (lista.Count > 0)
            {
                int min = lista[0];
                foreach (var item in lista)
                {
                    if (item < min)
                        min = item;
                }
                return min;
            }
            else
                return 0;
        };
        int min = menor(numeros);
        Console.WriteLine("Los numeros ingresados fueron: ");
        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Y el menor es: " + min);
        Console.ReadKey();
    }
}