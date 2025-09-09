namespace RC
{
    public class Recursividad
    {
        public int factorial(int numero)
        {
            //Caso base
            if (numero == 1 || numero == 0)
            {
                return 1;
            }

            //Caso general
            return numero * factorial(numero - 1);

        }
        public int fibonacci(int posicion)
        {
            if (posicion == 0)
            {
                return 0;
            }
            if (posicion == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(posicion - 1) + fibonacci(posicion - 2);
            }
        }
        public string revertir(string numero)
        {
            if (numero.Length == 1)
            {
                return numero;
            }
            else
            {
                return numero[numero.Length - 1] + revertir(numero.Substring(0, numero.Length - 1));
            }
        }
        public string abecedario(char inicio, char fin)
        {
            if (inicio > fin)
            {
                return "";
            }
            return inicio + " "+ abecedario((char)(inicio + 1), fin); ;
            
        }

    }
}
