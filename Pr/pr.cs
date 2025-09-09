namespace Pr
{
    public class pr
    {
        public int ContarVocales(string cadena, int indice = 0)
        {
            if (indice == cadena.Length)
            {
                return 0;
            }
            int contador = 0;
            char c = cadena[indice];

            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                contador = 1;
            }
            else
            {
                contador = 0;
            }      
            return contador + ContarVocales(cadena, indice + 1);
        }
        public int sumaDigitos(int numero)
        {
            if (numero == 0)
            {
                return 0;
            }
            else
            {
                return (numero % 10) + sumaDigitos(numero / 10);
            }
        }
        public int s(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else
            {
                return n + s(n - 1);
            }

        }
    }
}

