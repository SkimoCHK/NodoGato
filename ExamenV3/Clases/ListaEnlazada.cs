using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenV3.Clases
{
    public class ListaEnlazada
    {
        Nodo primerNodo;

        public bool ListaVacia()
        {
            return primerNodo == null ? true : false;
        }

        public void IngresarAlInicio(Gato gatito1)
        {
            Nodo nuevoNodo = new Nodo(gatito1);
            nuevoNodo._siguiente = primerNodo;
            primerNodo = nuevoNodo;

        }

        public void IngresarAlMedio(Gato gatito, Nodo siguiente) 
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista ta vacia mi lider");
                return;
            }

            Nodo nuevoNodo = new Nodo(gatito);
            nuevoNodo._siguiente = siguiente;

            //Sacar longitud de la lista!
            Nodo nodoActual = primerNodo;
            Nodo nodoAnterior = null;
            int longitud = 0;

            while (nodoActual != null)
            {
                longitud++;
                nodoActual = nodoActual._siguiente;
            }

            nodoActual = primerNodo;
            int mitadLista = longitud / 2;
            int bucle = 0;

            //Se posiciona la lista en la mitad!
            while (bucle < mitadLista)
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual._siguiente;
                bucle++;
            }

            //Se ingresa el valor en la mitad de la lista!
            nodoAnterior._siguiente = nuevoNodo;
            nuevoNodo._siguiente = nodoActual;

            
        
        }

        public void IngresarAlFinal(Gato gatito)
        {
            Nodo nuevoNodo = new Nodo(gatito);
            if (ListaVacia())
            {
                Console.WriteLine("La lista ta vacia mi bro");
                primerNodo = nuevoNodo;
                return;
            }

          
            Nodo nodoActual = primerNodo;
            while (nodoActual._siguiente != null)
            {
                nodoActual = nodoActual._siguiente;
            }
            nodoActual._siguiente = nuevoNodo;
        }

        public void EliminarElemento(Gato gatito)
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista ta vacia mi bro");
                return;
            }

            //En caso de que exista en la primera posicion!
            if(primerNodo._gato == gatito)
            {
                primerNodo = primerNodo._siguiente;
                Console.WriteLine("El elemento ha sido eliminado!");
            }

            Nodo nodoActual = primerNodo;
            Nodo nodoAnterior = null;
            while(nodoActual != null && nodoActual._gato != gatito)
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual._siguiente;
            }
            if(nodoActual == null)
            {
                Console.WriteLine("El elemento que quiere eliminar no existe!!");
            }

            nodoAnterior._siguiente = nodoActual._siguiente;
            Console.WriteLine("El elemento ha sido eliminado!!");

        }

        public void BuscarElemento(Gato gatito)
        {
            Nodo nodoActual = primerNodo;
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia!");
                return;
            }

            while(nodoActual != null && nodoActual._gato != gatito)
            {
                nodoActual = nodoActual._siguiente;
            }

            if (nodoActual == null){
                Console.WriteLine("No existe el elemento en la lista!");
                return;
            }

            Console.WriteLine($"El elemento {gatito} existe en la lista!");
           

        }
        public void RecorrerLista()
        {
            Nodo nodoActual = primerNodo;

            while (nodoActual._siguiente != null)
            {
                nodoActual = nodoActual._siguiente;

            }


        }




    }
}
