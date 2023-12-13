using Examenpr.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenpr.Servicios
{
    /// <summary>
    /// Clase que contiene la implementacion de los metodos de la OperativaInterfaz 
    /// @author JL - 13/12/2023
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz

    {
        public void borrarElemento(List<cubdto> listaAntigua)
        {
            throw new NotImplementedException();
        }

        public void darAltaCubiertos(List<cubdto> listaAntigua)
        {
            listaAntigua.Add(crearCubierto());
        }

        public void modificarCantidad(List<cubdto> listaAntigua)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método que recoge los atributos que crearan a un nuevo cubierto para
        /// que se añada a la lista.
        /// @author JL - 13/12/2023
        /// </summary>
        /// <returns></returns>
        private cubdto crearCubierto()
        {
            int idElemento;
            string nombreElemento;
            string codigoElemento;
            string descripcionElemento;
            int cantidadElemento;

            Console.WriteLine("Introduzca el id del cubierto: ");
            idElemento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca nombre del cubierto: ");
            nombreElemento = Console.ReadLine();
            codigoElemento = (idElemento + nombreElemento);
            Console.WriteLine(codigoElemento);
            Console.WriteLine("Introduzca descripcion del cubierto");
            descripcionElemento = Console.ReadLine();
            Console.WriteLine("Introduzca cantidad de cubiertos: ");
            cantidadElemento = Convert.ToInt32(Console.ReadLine());
            cubdto cubierto = new cubdto(idElemento, nombreElemento, codigoElemento, descripcionElemento, cantidadElemento);
            return cubierto;
        }
    }
}

