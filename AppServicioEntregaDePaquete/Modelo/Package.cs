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
        private double pesoPaquete;
        private double costoPaquete;
        private double calculateCost;

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

        public double PesoPaquete
        {
            get { return pesoPaquete; }
            set { pesoPaquete = value; }
        }

        public double CostoPaquete
        {
            get { return costoPaquete; }
            set { costoPaquete = value; }
        }

        public double CalculateCost
        {
            get { return calculateCost; }
            set { calculateCost = value; }
        }

        public Package() 
        {
            this.codigo = "XXXXXX";
            this.nombre = "nombre";
            this.direccion = "DDDDDD";
            this.ciudad = "City";
            this.estado = "N.N";
            this.pesoPaquete = 50;
            this.costoPaquete = 50.000;
            this.calculateCost = this.pesoPaquete * this.costoPaquete;
        }

        public Package(string codigo, string nombre, string direccion, string ciudad, string estado, double pesoPaquete, double costoPaquete, double calculeCost) 
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.estado = estado;
            this.pesoPaquete = pesoPaquete;
            this.costoPaquete = costoPaquete;
            this.calculateCost = calculateCost;
        }

        public override string ToString()
        {
            return "\n=================================\n" +
            "Código: " + this.codigo + "\n" +
            "Nombre: " + this.nombre + "\n" +
            "Dirección: " + this.direccion + "\n" +
            "Ciudad: " + this.ciudad + "\n" +
            "Estado: " + this.estado + "\n" +
            "Peso Del Paquete en Kg: " + this.pesoPaquete + "\n" +
            "Costo Del Paquete: " + this.costoPaquete + "\n" +
            "Cuota Total del Envio: " + this.calculateCost;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Package o = (Package)obj;
            bool result = false;

            if ((this.codigo == o.codigo) &&
                (this.nombre == o.nombre) && 
                (this.direccion == o.direccion) &&
                (this.ciudad == o.ciudad) && 
                (this.estado == o.estado) &&
                (this.pesoPaquete == o.pesoPaquete) && 
                (this.costoPaquete == o.costoPaquete) &&
                (this.calculateCost == o.calculateCost))
                result = true;

            return result;
        }
      
        
        
    }
}