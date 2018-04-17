using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz
    {
        private int[,] matriz;

        /// <summary>
        /// Tamaño de la matriz para ancho y alto
        /// </summary>
        private int t;

        public Matriz(int tamanio)
        {
            t = tamanio;
            matriz = new int[t,t];
        }

        public void Llenar()
        {
            int valor = 10;
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    matriz[i, j] = valor;
                    valor++;
                }
            }
        }

        public void LlenarColumnas()
        {
            int valor = 10;
            for (int j = 0; j < t; j++)
            {
                for (int i = 0; i < t; i++)
                {
                    matriz[i,j] = valor;
                    valor++;
                }
            }
        }

        public void LlenarInverso()
        {
            int valor = 10;
            for (int i = t-1; i >= 0 ; i--)
            {
                for (int j = t-1; j >= 0; j--)
                {
                    matriz[i,j] = valor;
                    valor++;
                }
            }
        }

        public String Mostrar()
        {
            string s = "Matriz completa" + Environment.NewLine;
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    s += matriz[i, j] + ",";
                }
                s += Environment.NewLine;
            }
            return s;
        }

        public String MostrarDP()
        {
            string s = "Diagonal Principal" + Environment.NewLine;
            
            for (int i = 0; i < t; i++)
            {
                s += matriz[i,i] + ",";
            }
            s += Environment.NewLine;
            return s;
        }

        public String MostrarDS()
        {
            string s = "Diagonal Secundaria" + Environment.NewLine;
            int j = t-1;
            for (int i = 0; i < t; i++)
            {
                s += matriz[i, j] + ",";
                j--;
            }
            s += Environment.NewLine;
            return s;
        }

        public String AbajoDP()
        {
            string s = "Abajo de la DP" + Environment.NewLine;
            for (int i = 1; i < t; i++)
            {
                for (int j = 0; j <= i-1; j++)
                {
                    s += matriz[i, j] + ",";
                }
                s += Environment.NewLine;
            }
            return s;
        }

        public String ArribaDS()
        {
            string s = "Arriba de la DS" + Environment.NewLine;
            for (int i = 0; i < t - 1; i++)
            {
                for (int j = 0; j < t - i - 1; j++)
                {
                    s += matriz[i, j] + ",";
                }
                s += Environment.NewLine;
            }
            return s;
        }

        public String InvertirDP()
        {
            string s = "Invertir sobre DP" + Environment.NewLine;
            int aux = 0;
            for (int j = 0; j < t-1; j++)
            {
                for (int i = j+1; i < t; i++)
                {
                    aux = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = aux;

                }
            }
            return s += Mostrar();
        }

        public String InvertirDS()
        {
            string s = "Invertir sobre DS" + Environment.NewLine;
            int aux = 0;
            for (int i = 0; i < t-1; i++)
            {
                for (int j = 0; j < t-i-1; j++)
                {
                    aux = matriz[i, j];
                    matriz[i, j] = matriz[t - j - 1, t - i - 1];
                    matriz[t - j - 1, t - i - 1] = aux;
                }
            }
            return s += Mostrar();
        }



    }
}
