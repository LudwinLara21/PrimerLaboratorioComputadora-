using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private String discoDuro;
        private String mouse;
        private String teclado;
        private String monitor;
        private String tarjetaMadre;
        private String fuenteDePoder;
        private String procesador;
        private String memoriaRAM;
        private String tarjetaGrafica;
        private String cpu;

        public string DiscoDuro { get => discoDuro; set => discoDuro = value; }
        public string Mouse { get => mouse; set => mouse = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Monitor { get => monitor; set => monitor = value; }
        public string TarjetaMadre { get => tarjetaMadre; set => tarjetaMadre = value; }
        public string FuenteDePoder { get => fuenteDePoder; set => fuenteDePoder = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string MemoriaRAM { get => memoriaRAM; set => memoriaRAM = value; }
        public string TarjetaGrafica { get => tarjetaGrafica; set => tarjetaGrafica = value; }
        public string CPU { get => cpu; set => cpu = value; }
    }
}
