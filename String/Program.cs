internal class Program
{
    private static void Main(string[] args)
    {
        Func<string, int, string> repetir = (txt, num) =>
        {
            string resultado = "";
            for (int i = 0; i < num; i++)
            {
                resultado = resultado + txt;
            }
            return resultado;
        };


        Console.WriteLine("Ingrese un texto");
        string txt = Console.ReadLine();
        Console.WriteLine("Ingrese un numero");
        int num = int.Parse(Console.ReadLine());
        string res = repetir(txt, num);
        Console.WriteLine("El resultado es: " + res);
        Console.ReadKey();

    }
}