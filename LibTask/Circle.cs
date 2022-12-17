using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTask
{
    public class Circle : Figure
    {
        private float r;

        public float R { get { return r; } }

        public Circle(float r)
        {
            this.r = r;
        }

        public override float GetSquare()
        {
            return MathF.PI * r * r;
        }
    }
}
