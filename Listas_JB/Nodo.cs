namespace Listas_JB
{
    public class Nodo
    {
        // Declaracion de variables o las propiedades
        private int dato;
        private Nodo siguiente;

        //encapsula el llamado de las propiedades del nodo
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}

