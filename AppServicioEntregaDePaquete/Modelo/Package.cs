using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquete.Modelo
{
    public class Package
    {
        private string codigo;
        private string nombre;
        private string direccion;
        private string ciudad;
        private string estado;
        private string pesoPaquete;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string PesoPaquete
        {
            get { return pesoPaquete; }
            set { pesoPaquete = value; }
        }

        public Package() 
        {
            this.codigo = "XXXXXX";
            this.nombre = "nombre";
            this.direccion = "DDDDDD";
            this.ciudad = "City";
            this.estado = "N.N";
            this.pesoPaquete = "X-KG.";
        }

        public Package(string codigo, string nombre, string direccion, string ciudad, string estado, string pesoPaquete) 
        {

        }

    }
}