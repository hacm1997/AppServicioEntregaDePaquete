using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaDePaquete.Modelo
{
    public class TwoDayPackage : Package
    {
        private double cuotaServicioEntregaDosDias;

        public double CuotaServicioEntregaDosDias
        {
            get { return cuotaServicioEntregaDosDias; }
            set { cuotaServicioEntregaDosDias = value; }
        }

        public TwoDayPackage() 
        {
            this.cuotaServicioEntregaDosDias = 100000;
        }

        public TwoDayPackage(double coutaServicioEntregaDosDias) 
        {
            this.cuotaServicioEntregaDosDias = cuotaServicioEntregaDosDias;
        }

        public override string ToString()
        {
            return "\n=================================\n" +
            "Cuota Total del Envio con el servicio de entre de 2 dias: " + this.cuotaServicioEntregaDosDias;
        }
    }
}