using System;

namespace interfacesENabstract
{
    public class Circle : Shape
    {
        private decimal radius;

        public decimal Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        
        public Circle(decimal radius,string naam,ColorTypes colorType, int colorDepth) : base(naam,colorType,colorDepth)
        {
            this.radius = radius;
        }
        
        public override decimal GetSurface()
        {
            return 4.0M * radius;
        }

        public override decimal GetCircumference()
        {
            return (decimal)Math.Pow((double) radius, 2);
        }

        public override string ToString()
        {
            return "Cirkel omtrek: "+GetCircumference()+" / oppervlakte: "+GetSurface()+" / "+base.ToString();
        }
    }
}