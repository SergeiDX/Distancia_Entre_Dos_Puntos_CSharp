using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia_Entre_Dos_Puntos_CSharp
{
    internal class Operaciones
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double resul { get; set; }
        

        public Operaciones(double x1, double x2, double y1, double y2, double resul)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.resul = resul;
        }

        public Operaciones()
        {
        }

        public double Operacion(double x1, double x2, double y1, double y2)
        {
            this.resul = Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)));
            return resul;
        }

    }
}
