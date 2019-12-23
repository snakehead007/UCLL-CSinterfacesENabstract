using System;

namespace interfacesENabstract
{
    public class Square : Shape
    {

        private decimal sideLenght;

        public decimal SideLenght
        {
            get { return sideLenght; }
            set { sideLenght = value; }
        }
        
        public Square(decimal sideLenght,string naam, ColorTypes colorType, int colorDepth) : base(naam, colorType,colorDepth)
        {
            this.sideLenght = sideLenght;
        }
        
        public override decimal GetSurface()
        {
            return 2.0M* (decimal)Math.PI * sideLenght;
        }

        public override decimal GetCircumference()
        {
            return (decimal) Math.PI * (decimal)Math.Pow((double)sideLenght, 2);
        }

        public override string ToString()
        {
            return "Vierkant omtrek: "+GetCircumference()+" / oppervlakte: "+GetSurface()+" / "+base.ToString();
        }
    }
}