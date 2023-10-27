using System;

namespace Listas_JB
{
    public class Lista
    {
        //se Declara de apuntero/punteros del nodo
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();
        // private Nodo Primero;

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public void Insertnodo(int valor)
        {
            //se crea el nuevo nodo
            Nodo Nuevo = new Nodo();
             Nuevo.Dato = valor;
          

            if (Primero == null)
            {
                Nuevo.Siguiente = null;
                Primero = Nuevo;
                Ultimo = Nuevo; 
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
                Ultimo = Nuevo; 
            }

            Console.WriteLine("Nodo Insertado al inicio de la lista.");
        }

        public void PrintList()
        {
            Nodo Actual = Primero;

            if (Actual != null)
            {
                Console.WriteLine("La lista de los Nodos es:");
                //Recorrrido de la lista
                while (Actual != null)
                {
                    Console.Write("{0}  ", Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La lista está vacía!!!");
            }
        }
    }
}
