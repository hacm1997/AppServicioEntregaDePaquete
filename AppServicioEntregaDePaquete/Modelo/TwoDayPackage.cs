using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquete.Modelo
{
    public class TwoDayPackage : Package
    {
        private double cuotaServicioEntregaDosDias;
        private double calculateCost2;

        public double CalculateCost2
        {
            get { return calculateCost2; }
            set { calculateCost2 = value; }
        }

        public double CuotaServicioEntregaDosDias
        {
            get { return cuotaServicioEntregaDosDias; }
            set { cuotaServicioEntregaDosDias = value; }
        }

        public TwoDayPackage() 
        {
            this.cuotaServicioEntregaDosDias = 100000;
            this.CalculateCost2 = this.CalculateCost + this.cuotaServicioEntregaDosDias;
        }

        public TwoDayPackage(double coutaServicioEntregaDosDias) 
        {
            this.cuotaServicioEntregaDosDias = cuotaServicioEntregaDosDias;
            this.CalculateCost2 = CalculateCost2;
        }

        public override string ToString()
        {
            return "\n=================================\n" +
            "Cuota del servicio de entrega de 2 días: " + this.cuotaServicioEntregaDosDias + "\n" +
            "Cuota Total del Envio con el servicio de entre de 2 dias: " + this.CalculateCost2;
        }


    }
}