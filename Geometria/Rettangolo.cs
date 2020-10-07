using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rettangolo
    {
        private int x;
        private int y;
        private double widht;
        private double height;
        public Rettangolo(int x, int y, double w, double h)
        {
            this.x = x;
            this.y = y;
            widht = w;
            height = h;
        }
        public bool Contiene(Rettangolo r)
        {
            if (r.x >= this.x && r.widht + r.x <= this.widht + this.x)
            {
                if (r.y >= this.y && r.height + r.y <= this.height + this.y)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public double CalcolaArea()
        {
            return widht * height;
        }
        public double CalcolaPerimetro()
        {
            return (widht + height) * 2;
        }

    }
}
