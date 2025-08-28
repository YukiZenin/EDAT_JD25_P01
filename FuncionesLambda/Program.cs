using FuncionesLambda;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Expresiones Lambda como funcion");
        //Func<int, int , int >b=(a)=>a*2;
        //int resultado =b(4);
        //Console.WriteLine("El resultado es: "+resultado);
        //Func<int, int, int> suma=(a,b)=>a+b;
        //int resultado = suma(4,6);
        //Console.WriteLine("El resultado es: " + resultado);
        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if (a > b) return a;
        //    else return b;
        //};
        //int resultado = mayor(45,20);
        //Console.WriteLine("El numero mayor es: " + resultado);
        //Persona pers = new Persona();
        //int edad=18;
        //edad++; 
        //edad++;
        //Console.ReadKey();
        //Console.WriteLine("El valor de la variable edad es: "+edad);
        //Console.WriteLine("La direccion de memoria es: " + ((IntPtr)edad).ToString("X"));
        var numeros = new List<int> {8 ,5,9,34,8};
        Func<int, bool> ObtenerPares = num => num % 2 == 0;
        var pares = numeros.Where(ObtenerPares);
        Console.WriteLine("Numeros pares:");
        foreach (var item in pares)
        {
            Console.WriteLine(item);
        }
    }
}