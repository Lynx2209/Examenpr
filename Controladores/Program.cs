using Examenpr.Dtos;
using Examenpr.Servicios;

namespace Examenpr.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion 
    /// @author JL - 13/12/2023
    /// </summary>
    /// <param name="args"></param>
    internal class Program
    {
        /// <summary>
        /// metodo de entrada a lla aplicacion
        /// @author JL - 13/12/2023
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            List<cubdto> listaCubiertos = new List<cubdto>();

            int seleccionUsuario;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                seleccionUsuario = mi.mostrarMenuYSeleccion();
                switch (seleccionUsuario)
                {
                    case 0:
                        Console.WriteLine("Se ejecuta caso 0");
                            cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se ejecuta caso 1");
                        oi.darAltaCubiertos(listaCubiertos);
                       
                        foreach (cubdto cubierto in listaCubiertos)
                        {
                            Console.WriteLine(cubierto.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Se ejecuta caso 2");
                        oi.borrarElemento(listaCubiertos);
                        foreach (cubdto cubierto in listaCubiertos)
                        {
                             Console.WriteLine (cubierto.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Se ejecuta caso 3");
                        foreach (cubdto cubierto in listaCubiertos)
                        {
                            Console.WriteLine(cubierto.ToString());
                        }
                        break;
                    case 4:
                        Console.WriteLine("Se ejecuta caso 4 ");
                        oi.modificarCantidad(listaCubiertos);
                        break;
                    default:
                        Console.WriteLine("Introduzca una opcion valida");
                        break;


                }
            }
        }
    }
}

