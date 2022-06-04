using System;
using System.Collections.Generic;

namespace DelegadosPredicadosLamdasII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas();
            p1.Nombre = "Juan";
            p1.Edad = 18;

            Personas p2 = new Personas();
            p1.Nombre = "Maria";
            p1.Edad = 28;

            Personas p3 = new Personas();
            p1.Nombre = "Josefa";
            p1.Edad = 48;

            gente.AddRange(new Personas[] { p1, p2, p3 });

            Predicate<Personas> Predicado = new Predicate<Personas>(ExisteJuan);
            //dependiendo de las devoluciones se le asigna el valor, en el otro era una lista en este es un bool
            //prueba si existe el predicado
            bool existe = gente.Exists(Predicado);
            //prueba la verdad del bool
            if (existe) Console.WriteLine("Hay mayores de edad");
            else Console.WriteLine("No hay mayores de edad");

            //---------------------------------------------------------------------------------------------------
            /*List<int> listaNumeros = new List<int>();
            //meter dentro de la coleccion un array de valores
            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Declaramos delegado predicado
            //sirve para filtrar elementos en cuanto sea verdad o sea falso
            Predicate<int> ElDelegadoPredicado = new Predicate<int>(DamePares);
            //se crea una lista que sera devuelta
            //el predicado define las condiciones del elemento que se va a buscar
            //findAll recupera todos los elementos que coinciden con las condiciones definidas por el predicado
            List<int> numPares = listaNumeros.FindAll(ElDelegadoPredicado);
            //cada vuelta imprime el valor de num
            foreach(int num in numPares)
            {
                Console.WriteLine(num);
            }*/

        }

        //recibe objeto de tipo persona, los delegados sirven tambien para evaluar las expresiones de las clases
        static bool ExisteJuan(Personas personas)
        {
            if (personas.Edad>18) return true;

            else return false;
        }
        /* static bool DamePares(int num)
         {
             if (num % 2 == 0) return true;

             else return false;
         }*/

    }
    class Personas
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public int Edad { get => edad; set => edad = value; }

        private int edad;
    }
}
        

