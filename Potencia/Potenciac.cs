namespace Potencia
{
    public class Potenciac
    {
        public int potencia(int numero, int potencia)
        {
            for (int i = 1; i <= potencia; i++)
            {
                numero = numero * numero;
            }
            return numero;
        }
    }
}
