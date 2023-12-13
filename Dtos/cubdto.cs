using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examenpr.Dtos
{
    /// <summary>
    /// Clase principal que contiene todos los atributos de CubDtos
    /// @author JL - 13/12/2023
    /// </summary>
    internal class cubdto
    {
        int idElemento;
        string nombreElemento;
        string codigoElemento;
        string descripcionElemento;
        int cantidadElemento;

        /// <summary>
        /// Constructor vacio por defecto
        /// @author JL - 13/12/2023
        /// </summary>
        public cubdto()
        {
        /// <summary>
        /// métodos get y set que forman una estructura con caracteristicas que identifican a cada elemento añadido
        /// @author JL - 13/12/2023
        /// </summary>
        public int IdElemento { get => idElemento; set => idElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        /// <summary>
        /// Constructor al cual se le llamara cuando se le haga una copia (new) de los elementos que lo componen
        /// @author JL - 13/12/2023
        /// </summary>
        /// <param name="idElemento"></param>
        /// <param name="nombreElemento"></param>
        /// <param name="codigoElemento"></param>
        /// <param name="descripcionElemento"></param>
        /// <param name="cantidadElemento"></param>
        public cubdto (int idElemento, string nombreElemento, string codigoElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.nombreElemento = nombreElemento;
            this.codigoElemento = codigoElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        /// <summary>
        /// Método to string el cual convierte a el objeto a tipo string  
        /// @author JL 13/12/2023
        /// </summary>
        /// <returns>un tipo string del objeto</returns>
        public string ToString()
        {
            string tipoCubierto = "Id del cubierto: " + this.idElemento +
                "Nombre del cubierto : " + this.nombreElemento +
                "Codigo del cubierto :" + this.codigoElemento +
                "Descripcion del cubierto: " + this.descripcionElemento +
                "Cantidad de cubiertos: " + this.cantidadElemento;
            return tipoCubierto;


        }
    }
}




