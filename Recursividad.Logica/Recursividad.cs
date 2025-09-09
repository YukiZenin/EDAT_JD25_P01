namespace Recursividad_Logica
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
        public int Potencia(int numero, int potencia)
        {
            if (potencia == 0)
            {
                return 1;
            }
            //for (int i = 1; i < potencia; i++)
            //{
            //    numero = numero * numero;
            //}
            return numero* Potencia(numero,potencia-1);
        }
    }
}
