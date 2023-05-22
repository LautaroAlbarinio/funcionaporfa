using System;

namespace ConsoleApp1
{
    public static class analizarNumero
    {
        public static Boolean analizarPrimo(int numero)
        {
            int i;
            for(i = 2; i < numero ; i++ )
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}