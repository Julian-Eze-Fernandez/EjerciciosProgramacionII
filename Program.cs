using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class Ejercicio
{
    public static void Main()
    {

        #region C#073 "Colas"
        //Cola = Estructura FIFO
        //Queue<int> cola = new Queue<int>();
        //cola.Enqueue(20);
        //cola.Enqueue(10);
        //cola.Enqueue(5);

        //while (cola.Count > 0)
        //{
        //    int dato = cola.Dequeue();
        //    Console.WriteLine(dato);
        //}

        //--------------------------------------------------------
        //------------------------EJERCICIO-----------------------
        //--------------------------------------------------------

        //Queue<string> cola = new Queue<string>();

        //while (true) 
        //{
        //    Console.WriteLine("Introduzca lo que quiera.");
        //    Console.WriteLine("Cuando quiera ver lo introducido solo ingresar un espacio vacio.");
        //    Console.WriteLine("");

        //    string dato = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (dato == "")
        //    {
        //        Console.WriteLine("Los datos ingresados por el usuarios son:");
        //        MostrarDatos(cola);
        //        break;
        //    }
        //    else
        //    {
        //        cola.Enqueue(dato);
        //    }
        //}

        //static void MostrarDatos(Queue<string> cola)
        //{
        //    while (cola.Count > 0)
        //    {
        //        string dato = (string)cola.Dequeue();
        //        Console.WriteLine(dato);
        //    }
        //}

        #endregion

        #region C#074 "Pilas"
        // Pila = Estructura LIFO
        //Stack<int> pila = new Stack<int>();
        //pila.Push(20);
        //pila.Push(10);
        //pila.Push(5);

        ////while (pila.Count > 0)
        //int max = pila.Count;
        //for (int i = 0; i < max; i++)
        //{
        //    int dato = pila.Pop();
        //    Console.WriteLine(dato);
        //}

        //--------------------------------------------------------
        //------------------------EJERCICIO-----------------------
        //--------------------------------------------------------

        //Stack<string> pila = new Stack<string>();

        //while (true)
        //{
        //    Console.WriteLine("Introduzca lo que quiera.");
        //    Console.WriteLine("Cuando quiera ver lo introducido solo ingresar un espacio vacio.");
        //    Console.WriteLine("");

        //    string dato = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (dato == "")
        //    {
        //        Console.WriteLine("Los datos ingresados por el usuarios son:");
        //        MostrarDatos(pila);
        //        break;
        //    }
        //    else
        //    {
        //        pila.Push(dato);
        //    }
        //}

        //static void MostrarDatos(Stack<string> pila)
        //{
        //    while (pila.Count > 0)
        //    {
        //        string dato = pila.Pop();
        //        Console.WriteLine(dato);
        //    }
        //}
        #endregion

        #region C#075 "ArrayList"

        //List <int> lista = new List<int>();
        //lista.Add(20);
        //lista.Add(10);
        //lista.Add(5);
        //lista.Insert(1, 30);
        //lista.Remove(20);
        //lista.RemoveAt(2);

        //for (int i = 0; i < lista.Count; i++)
        //{
        //    int dato = lista[i];
        //    Console.WriteLine(dato);
        //}

        //--------------------------------------------------------
        //------------------------EJERCICIO-----------------------
        //--------------------------------------------------------
        //ArrayList lista = new ArrayList();

        //while (true) 
        //{
        //    Console.WriteLine("Ingrese la cadena de texto que desee.");
        //    Console.WriteLine("Cuando quiera ver lo introducido solo ingresar un espacio vacio.");
        //    Console.WriteLine("");

        //    string dato = Console.ReadLine();

        //    Console.WriteLine("");

        //    if (dato == "")
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine("A que posicion de la lista desea acceder? (ingrese el numero).");
        //            Console.WriteLine("Si no desea visualizar ninguna posicion ingrese el numero 0 para SALIR.");
        //            Console.WriteLine("");

        //            int posicion = Convert.ToInt32(Console.ReadLine());

        //            if (posicion == 0)
        //            {
        //                Environment.Exit(0);
        //            }
        //            else
        //            {
        //                Console.WriteLine("En posicion " + posicion + " se encuentra:" + "{0}", lista[posicion -1]);
        //                Console.WriteLine("");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        lista.Add(dato);
        //    }
        //}

        #endregion

        #region C#077 "SortedList"

        //SortedList<string,string> diccio = new SortedList<string,string>();
        //diccio.Add("hola", "hello");
        //diccio["hasta luego"] = "see you later";

        //Console.WriteLine( diccio["hola"] );

        //if (diccio.ContainsKey("adiós"))
        //{
        //    Console.WriteLine(diccio["adiós"]);
        //}

        //--------------------------------------------------------
        //------------------------EJERCICIO-----------------------
        //--------------------------------------------------------

        SortedList<string, string> diccio = new SortedList<string, string>();
        diccio.Add("hello", "hola");
        diccio.Add("good bye", "chau");
        diccio.Add("see you later", "nos vemos");
        diccio.Add("how are you?", "¿como estas?");
        diccio.Add("i`m fine", "estoy bien");
        diccio.Add("thanks", "gracias");
        diccio.Add("your welcome", "de nada");
        diccio.Add("yes", "si");
        diccio.Add("no", "no");

        //while (true) 
        //{
        //    Console.Write("Ingresa una clave: ");
        //    string clave = Console.ReadLine();

        //    if (diccio.ContainsKey(clave))
        //    {
        //        Console.WriteLine("{1}", clave, diccio[clave]);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"La clave {clave} no existe");
        //    }
        //}      

        #endregion
    }
}
