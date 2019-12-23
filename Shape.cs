using System;

namespace interfacesENabstract
{
    public abstract class Shape: IColorObject
    {
        private ColorTypes colorType;
        public ColorTypes ColorType
        {
            get { return colorType;}
            set { colorType = value; }
        }

        private int colorDepth;
        public int ColorDepth
        {
            get { return colorDepth; }
            set { colorDepth = value; }
        }


        private string naam;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public Shape(string naam,ColorTypes colorType, int colorDepth)
        {
            this.colorType = colorType;
            this.colorDepth = colorDepth;
            this.naam = naam;
        }

        public override string ToString()
        {
            string str = "Kleur type: "+colorType+" / Kleur Diepte "+colorDepth;
            if (naam != null || !naam.Trim().Equals(""))
            {
                return "Naam: " + naam + " / " + str;
            }

            return str;
        }

        public abstract decimal GetSurface();
        public abstract decimal GetCircumference();
        
        
    }
}