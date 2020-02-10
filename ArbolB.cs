using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETD2LAB1
{
    public class ArbolB<T> where T : IComparable
    {

        public class Nodo
        {
            public Nodo Padre;
            public int grado;
            public T[] vector;
            public Nodo[] hijo;
            public bool EsHoja;
            public bool EstaLleno;

            public Nodo(int grado)
            {
                vector = new T[grado];
                hijo = new Nodo[grado];
                EstaLleno = false;
                this.grado = grado;
                EstaLleno = false;
            }

            public void Insertar(T valor)
            {

                int i = 0;
                while (i < grado - 1 && EstaLleno == false)
                {
                    if (this.vector[i] == null)
                    {
                        vector[i] = valor;

                        if (i == vector.Length - 1)
                        {
                            EstaLleno = true;
                        }
                    }
                    i++;
                }

            }

            public void Ordenar()
            {

                for (int p = 0; p <= vector.Length - 2; p++)
                {
                    for (int i = 0; i <= vector.Length - 2; i++)
                    {
                        if (vector[i + 1] != null)
                        {


                            if (vector[i].CompareTo(vector[i + 1]) == 1)
                            {
                                var temp = vector[i + 1];
                                vector[i + 1] = vector[i];
                                vector[i] = temp;



                            }

                        }
                    }
                }
            }

            public void BuscarEnNodo(T valor)
            {
                int i = 0;
                T dato = default;
                while (vector[i] != null)
                {
                    if (valor.CompareTo(vector[i]) == 0)
                    {
                        dato = vector[i];

                    }

                }

            }

        }

    }
}
