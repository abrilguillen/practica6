using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Cola
{
    class Queue
    {
        private Proceso inicio;
        private int _contadorProcesos = 0;

        public void meter(Proceso nuevo)
        {
            if (inicio == null)//si  la cola esta vacia...
            {
                inicio = nuevo;
            }
            else
            {
                nuevo.siguiente = inicio;//si la cola si tiene algo
                inicio = nuevo;
            }

            _contadorProcesos++;
        }

        public Proceso sacar()
        {
            if (inicio != null)
            {
                Proceso temporal;

                if (inicio.siguiente == null)
                {
                    temporal = inicio;
                    inicio = null;
                    _contadorProcesos--;

                    return temporal;
                }
                else
                {
                    Proceso final = inicio;

                    while (final.siguiente.siguiente != null)
                    {
                        final = final.siguiente;
                    }

                    temporal = final.siguiente;
                    final.siguiente = null;
                    _contadorProcesos--;

                    return temporal;
                }
            }

            return null;
        }

        public Proceso cima()
        {
            if (inicio != null)
            {
                Proceso temporal = inicio;

                while (temporal.siguiente != null)
                {
                    temporal = temporal.siguiente;
                }

                return temporal;
            }

            return null;
        }

        public override string ToString()
        {
            string mostrar = "";

            if (inicio != null)
            {
                Proceso temporal = inicio;
                int procesosPendientes = 0;

                while (temporal.siguiente != null)
                {
                    procesosPendientes += temporal.tiempoProceso;
                    temporal = temporal.siguiente;
                }

                mostrar += "Número de procesos pendientes: " + _contadorProcesos + Environment.NewLine;
                mostrar += "Suma de los procesos pendientes: " + procesosPendientes;
            }
            else
                mostrar = "No hay procesos pendientes";

            return mostrar;
        }
    }
}
