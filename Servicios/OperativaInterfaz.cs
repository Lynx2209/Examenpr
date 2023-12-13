using Examenpr.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenpr.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método para dar de alta un nuevo elemento a la lista de cubiertos.
        /// @author JL - 13/12/2023
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCubiertos(List<cubdto> listaAntigua);

        /// <summary>
        /// Método para eliminar un elemento de la lista.
        /// @author JL - 13/12/2023
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void borrarElemento(List<cubdto> listaAntigua);


        /// <summary>
        /// Metodo que permite modificar la cantidad de un cubierto
        /// @author JL - 13/12/2023
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void modificarCantidad(List<cubdto> listaAntigua);
    }
}
