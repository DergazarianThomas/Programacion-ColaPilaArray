
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Ejercicio
{
    public static void Main()
    {
        #region 073
        //Queue<string> cola = new Queue<string>();

        //while (true)
        //{
        //    Console.WriteLine("Escriba las cadenas de texto que desee almacenar en la queue");
        //    Console.WriteLine("o introduzca una cadena vacia para recibir lo almacenado en la queue");
        //    Console.WriteLine("");

        //   string datoEnQueue = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (datoEnQueue == "")
        //    {
        //        MostrarQueue(cola);
        //        break;
        //    }
        //    else
        //    {
        //        cola.Enqueue(datoEnQueue);
        //    }
        //}

        //static void MostrarQueue(Queue<string> cola)
        //{
        //    while (cola.Count > 0)
        //    {
        //        string dato = (string) cola.Dequeue();

        //        Console.WriteLine(dato);
        //    }
        //}
        #endregion

        #region 074

        //Stack<string> Pila = new Stack<string>();

        //while (true)
        //{
        //    Console.WriteLine("Escriba las cadenas de texto que desee almacenar en la Pila");
        //    Console.WriteLine("o introduzca una cadena vacia para recibir lo almacenado en la Pila");
        //    Console.WriteLine("");

        //    string datoEnPila = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (datoEnPila == "")
        //    {
        //        MostrarPila(Pila);
        //        break;
        //    }
        //    else
        //    {
        //        Pila.Push(datoEnPila);
        //    }
        //}

        //static void MostrarPila(Stack<string> Pila)
        //{
        //    while (Pila.Count > 0)
        //    {
        //        string dato = (string)Pila.Pop();

        //        Console.WriteLine(dato);
        //    }
        //}
        #endregion

        #region 075

        ArrayList listaArray = new ArrayList();

        while (true)
        {
            Console.WriteLine("Escriba las cadenas de texto que desee almacenar en la Array");
            Console.WriteLine("o introduzca una cadena vacia para consultar lo almacenado en la Array");
            Console.WriteLine("");

            string datoEnArray = Console.ReadLine();

            Console.WriteLine("");

            if (datoEnArray == "")
            {
                while (true)
                {
                    Console.WriteLine("Que posicion de la Array desea consultar? (Inserte un numero)");
                    Console.WriteLine("o introduzca el numero 0 para terminar el programa");
                    Console.WriteLine("");

                    int PosicionEnArray = Convert.ToInt32(Console.ReadLine());

                    if (PosicionEnArray == 0)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("En posicion " + PosicionEnArray + " se encuentra:" + "{0}", listaArray[PosicionEnArray]);
                        Console.WriteLine("");
                    }
                    
                }
            }
            else
            {
                listaArray.Add(datoEnArray);
            }
        }

        #endregion
    }




}
