namespace interfacesENabstract
{
    public class Picture : IColorObject
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

        private string location;
        public string Location
        {
            get { return location;}
            set { location = value; }
        }

        private Shape shape;

        public Picture(string location, ColorTypes colorType, int colorDepth)
        {
            this.location = location;
            this.colorType = colorType;
            this.colorDepth = colorDepth;
        }
        
        public override string ToString()
        {
            return "Foto locatie: "+location+" / Kleur type: "+colorType+" / Kleur Diepte "+colorDepth;
        }
    }
}