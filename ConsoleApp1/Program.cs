
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Ejercicio
{
    #region 076

    struct amigo
    {
        public string nombre;
        public string apellido;
        public int numero;
    }

    static List<amigo> amigos;

    #endregion


     static void Main()
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

        //ArrayList listaArray = new ArrayList();

        //while (true)
        //{
        //    Console.WriteLine("Escriba las cadenas de texto que desee almacenar en la Array");
        //    Console.WriteLine("o introduzca una cadena vacia para consultar lo almacenado en la Array");
        //    Console.WriteLine("");

        //    string datoEnArray = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (datoEnArray == "")
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine("Que posicion de la Array desea consultar? (Inserte un numero)");
        //            Console.WriteLine("o introduzca el numero 0 para terminar el programa");
        //            Console.WriteLine("");

        //            int PosicionEnArray = Convert.ToInt32(Console.ReadLine());

        //            if (PosicionEnArray == 0)
        //            {
        //                Environment.Exit(0);
        //            }
        //            else
        //            {
        //                Console.WriteLine("En posicion " + PosicionEnArray + " se encuentra:" + "{0}", listaArray[PosicionEnArray]);
        //                Console.WriteLine("");
        //            }

        //        }
        //    }
        //    else
        //    {
        //        listaArray.Add(datoEnArray);
        //    }
        //}

        #endregion

        #region 076
        amigos = new List<amigo>();

        string opcion;

        menu();
        #endregion

        #region 077

        //SortedList diccio = new SortedList();

        //diccio.Add("hi", "hola");

        //diccio.Add("how", "como");

        //diccio.Add("you", "tu");

        //diccio.Add("new", "nuevo");

        //diccio.Add("how are you", "Como estas");

        //diccio.Add("how old are you", "Cuantos años tienes");

        //diccio.Add("my", "mi");

        //diccio.Add("I", "yo");

        //diccio.Add("am", "soy");

        //diccio.Add("is", "es");

        //diccio.Add("name", "nombre");


        //Console.WriteLine("Escriba una frase con palabras que desee traducir del ingles al español");
        //Console.WriteLine("");

        //string phrase = Console.ReadLine();
        //Console.WriteLine("");

        //string[] words = phrase.Split(' ');

        //foreach (var word in words)
        //{

        //    if(diccio.ContainsKey(word))
        //    {
        //       Console.WriteLine(word + "=" +  diccio[word]);
        //    }
        //}
        //Console.ReadLine();
        #endregion

        #region 078

        //Dictionary<string, string> diccio = new Dictionary<string, string>();

        //diccio.Add("hi", "hola");

        //diccio.Add("how", "como");

        //diccio.Add("you", "tu");

        //diccio.Add("new", "nuevo");

        //diccio.Add("how are you", "Como estas");

        //diccio.Add("how old are you", "Cuantos años tienes");

        //diccio.Add("my", "mi");

        //diccio.Add("I", "yo");

        //diccio.Add("am", "soy");

        //diccio.Add("is", "es");

        //diccio.Add("name", "nombre");


        //Console.WriteLine("Escriba una frase con palabras que desee traducir del ingles al español");
        //Console.WriteLine("");

        //string phrase = Console.ReadLine();
        //Console.WriteLine("");

        //string[] words = phrase.Split(' ');

        //foreach (var word in words)
        //{

        //    if (diccio.ContainsKey(word))
        //    {
        //        Console.WriteLine(word + "=" + diccio[word]);
        //    }
        //}
        //Console.ReadLine();

        #endregion

        #region 079

        SortedSet<string> diccio = new SortedSet<string>();

        while(true) {
            Console.WriteLine("Escriba una frase unica que para añadir");
            Console.WriteLine("");

            string phrase = Console.ReadLine();
            Console.WriteLine("");

            if (diccio.Contains(phrase))
            {

                Console.WriteLine("[ " + phrase + " ]" + " ya existe");
                
            }
            else
            {

                diccio.Add(phrase);

                Console.WriteLine("");
                Console.WriteLine("Frase añadida");
            }

            Console.ReadLine();
            Console.Clear();
        }
        #endregion
    }

    #region 076

    static void menu()
    {
        Console.Clear();

        Console.WriteLine("[1] Añadir amigo ");
        Console.WriteLine("[2] Ver amigos ");
        Console.WriteLine("[3] Borrar ");
        Console.WriteLine("[4] Modificar");

        string option = Console.ReadLine();

        if (option == "1")
        {
            Console.Clear();
            add();
        }
        else if (option == "2")
        {
            Console.Clear();
            verDatos();
        }
        else if (option == "3")
        {
            Console.Clear();
            delete();
        }
        else if(option == "4") 
        {
            Console.Clear();
            modify();
        }
    }

    static void add()
    {
        amigo a;

        Console.WriteLine("");
        Console.WriteLine("Nombre? ");
        Console.WriteLine("");
        a.nombre = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Apellido? ");
        Console.WriteLine("");
        a.apellido = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Numero? ");
        Console.WriteLine("");
        a.numero = Convert.ToInt32(Console.ReadLine());

        amigos.Add(a);

        Console.ReadLine();
        menu();
    }

    static void verDatos()
    {
        foreach (var amigo in amigos)
        {
            Console.WriteLine($"Nombre: {amigo.nombre}, Apellido: {amigo.apellido}, Numero: {amigo.numero} ");
            Console.WriteLine("");
        }
        Console.ReadLine();
        menu();
    }

    static void delete()
    {
        Console.WriteLine("posicion de amigo a borrar");
        int poscBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine("");

        if (poscBorrar >= amigos.Count)
        {
            Console.WriteLine("No hay tantos amigos");
        }
        else if (poscBorrar <= -1)
        {
            Console.WriteLine("No se aceptan numeros negativos");
        }
        else
        {
            amigos.RemoveAt(poscBorrar);
            Console.WriteLine("Amigo borrado");
        }
        Console.ReadLine();
        menu();
    }

    static void modify()
    {
        Console.WriteLine("Posicion de amigo a modificar");
        int poscModify = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine("");

        if (poscModify >= amigos.Count)
        {
            Console.WriteLine("No hay tantos amigos");
            Console.ReadLine();
        }
        else if (poscModify <= -1)
        {
            Console.WriteLine("No se aceptan numeros negativos");
            Console.ReadLine();
        }
        else
        {
            amigo a = amigos[poscModify];
            Console.WriteLine("Nombre? (era {0}): ", amigos[poscModify].nombre);
            Console.WriteLine("");

            string response = Console.ReadLine();
            if (response != "")
            {
                a.nombre = response;
            }
            else
            {
                Console.WriteLine("Error, valor nulo");
                menu();
            }
            Console.WriteLine("");

            Console.WriteLine("Apellido? (era {0}): ", amigos[poscModify].apellido);
            Console.WriteLine("");

            response = Console.ReadLine();
            if (response != "")
            {
                a.apellido = response;
            }
            else
            {
                Console.WriteLine("Error, valor nulo");
                menu();
            }
            Console.WriteLine("");

            Console.WriteLine("Numero? (era {0}): ", amigos[poscModify].numero);
            Console.WriteLine("");

            response = Console.ReadLine();
            if (response != "")
            {
                a.numero = Convert.ToInt32(response);
            }
            else
            {
                Console.WriteLine("Error, valor nulo");
                menu();
            }
            Console.WriteLine("");
        }

    }
    #endregion


}
