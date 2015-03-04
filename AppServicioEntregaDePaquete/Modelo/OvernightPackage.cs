using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquete.Modelo
{
    public class OvernightPackage : Package
    {
        private double costoEntregaNoche;
        private double calculateCost3;

        public double CalculateCost3
        {
            get { return calculateCost3; }
            set { calculateCost3 = value; }
        }

        public double CostoEntregaNoche
        {
            get { return costoEntregaNoche; }
            set { costoEntregaNoche = value; }
        }

        public OvernightPackage() 
        {
            this.costoEntregaNoche = 65000;
            this.calculateCost3 = this.CalculateCost + this.costoEntregaNoche;
        }

        public OvernightPackage(double costoEntregaNoche, double calculateCsot3) 
        {
            this.costoEntregaNoche = costoEntregaNoche;
            this.calculateCost3 = calculateCost3;
        }

        public override string ToString()
        {
            return "\n=================================\n" +
            "Cuota del servicio de entrega por la Noche: " + this.costoEntregaNoche + "\n" +
            "Cuota Total del Envio con el servicio por la Noche: " + this.CalculateCost3;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            OvernightPackage o = (OvernightPackage)obj;
            bool result = false;

            if ((this.costoEntregaNoche == o.costoEntregaNoche) &&
                (this.calculateCost3 == o.calculateCost3))
                result = true;

            return result;
        }

    }
}