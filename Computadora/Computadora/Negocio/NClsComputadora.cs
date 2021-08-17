using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {



        public String Apagar(ClsComputadora computadora)
        {
            return "La computadora con procesador" + computadora.Procesador + "Se esta apagando ";

        }

        public String monitor(ClsComputadora computadora)
        {
            return "El monitor " + computadora.Monitor + "Esta dañado ";

        }

        public String teclado(ClsComputadora computadora)
        {
            return "El teclado " + computadora.Teclado + "esta fallando ";

        }

        public String fuente(ClsComputadora computadora)
        {
            return "La fuente   " + computadora.FuenteDePoder + "No esta conectado ";
        }

        public String Encender(ClsComputadora computadora)
        {
            return "La computadora con memoria RAM de " + computadora.MemoriaRAM + " y micro procesador " + computadora.Procesador + " esta encendida";

        }
    }
}

