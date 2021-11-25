using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ClassISBN2
    {

        public static string VerifyISBN(int[] numero)
        {

            if(numero.Length == 10)
            {
                int multiplicacion = 0;
                int sumatoria = 0;
                int posicion = 10;

                for(int i = 0; i < numero.Length; i++)
                {
                    multiplicacion = numero[i] * posicion;
                    sumatoria += multiplicacion;
                    multiplicacion = 0;
                    posicion--;
                }

                if(sumatoria % 11 == 0)
                {
                    return "ISBN VALIDO";
                }
                else
                {
                    return "ISBN NO VALIDO";
                }
            }
            else if(numero.Length == 13)
            {
                int multiplicacion = 0;
                int sumatoria = 0;

                for (int i = 0; i < numero.Length; i++)
                {
                    if(numero[i] % 2 == 0)
                    {
                        multiplicacion = numero[i] * 3;
                    }
                    else
                    {
                        multiplicacion = numero[i] * 1;
                    }
                    sumatoria = sumatoria + multiplicacion;
                }

                if(sumatoria % 10 == 0)
                {
                    return "ISBN VALIDO";
                }
                else
                {
                    return "ISBN NO VALIDO";
                }
            }
            else
            {
                return "ISBN NO VALIDO";
            }

        }

    }
}
