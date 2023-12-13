
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenpr.Servicios
{
    /// <summary>
    /// Clase que contiene la implementacion de cada metodo del menu Interfaz
    /// @author JL - 13/12/2023
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionseleccionada;
            Console.WriteLine("#####################################");
            Console.WriteLine("Seleccione una opcción para ejecutarla");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Dar de alta nuevo elemento");
            Console.WriteLine("2.Eliminar elemento");
            Console.WriteLine("3.Ver lista de elementos");
            Console.WriteLine("4.Modificar cantidad elementos");
            Console.WriteLine("#####################################");
            opcionseleccionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionseleccionada;
        }
        public int pedirElemento()
        {
            int idAEncontrar;
            Console.WriteLine("Introduzca el número id del elemento a borrar");
            idAEncontrar = Convert.ToInt32(Console.ReadLine());
            return idAEncontrar;
        }
    }
}

