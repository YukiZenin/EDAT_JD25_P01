internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Complejidad de algoritmos \n");
        //Console.WriteLine("Complejidad Big o(1)");
        //var nombres = new List<string> { "Ileny","Alondra","Jose","Juan","Alejandro","Karlita<3"};
        //var primero = (List<String> arreglo )=> arreglo!=null && arreglo.Count>0?
        //arreglo[0]: "Lista vacia";
        //Console.WriteLine(primero(nombres));
        //Console.ReadKey();
        Console.WriteLine("Complejidad Big 0(n)");
        var numeros = new List<int>() { 45,22,53,500,2000,10000,0,1};
        var numeroMayor = (List<int> arreglo) =>
        {
            if (arreglo.Count == 0 || arreglo == null)
            {
                return 0;
            }
                int mayor = arreglo[0];
                for (int i = 0; i < arreglo.Count; i++)
                {
                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                }
                }
                return mayor;
            
        };
        int may = numeroMayor(numeros);
        Console.WriteLine("El numero mayor es: "+may);
        Console.ReadKey();
    }
}