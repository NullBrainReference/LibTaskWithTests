namespace LibTask
{
    public class Triangle: Figure
    {
        private float a;
        private float b;
        private float c;

        public float A { get { return a; }}
        public float B { get { return b; }}
        public float C { get { return c; }}

        public Triangle(float a, float b, float c)
        {
            if (CheckExistence(a, b, c)) {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new TriangleExistenceException();
            }
        }

        private bool CheckExistence(float a, float b, float c)
        {
            if (a > b + c) return false;
            if (b > a + c) return false;
            if (c > b + a) return false;

            return true;
        }

        public override float GetSquare()
        {
            return (float)Math.Sqrt(P() * (P() - a) * (P() - b) * (P() - c));
        }

        private float P()
        {
            return (a + b + c) / 2;
        }

        public bool IsRight()
        {
            if (a * a == b * b + c * c) return true;
            if (b * b == a * a + c * c) return true;
            if (c * c == b * b + a * a) return true;

            return false;
        }
    }
}
