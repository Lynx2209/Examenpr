using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenpr.Servicios
{
    /// <summary>
    /// Interfaz que contiene la relacion de metodos con la funcionalidad del menu 
    /// @author JL - 13/12/2023
    /// </summary>

    internal interface MenuInterfaz

    {
        /// <summary>
        /// Metodo que recoge el menu y muestra la opcion introducida por el usuario 
        /// @author JL - 13/12/2023
        /// </summary>
        /// <returns> tipo int que contendra la opcion del usuario que haya seleccionado </returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Metodo para solictar al usuario el id del elemento .
        /// @author JL - 13/12/2023
        /// </summary>
        /// <returns> un string con el idElemento</returns>
        public int pedirElemento();
    }
}
