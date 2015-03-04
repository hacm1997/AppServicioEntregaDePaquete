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

    }
}