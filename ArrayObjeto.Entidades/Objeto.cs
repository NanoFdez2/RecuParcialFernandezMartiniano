namespace ArrayObjeto.Entidades
{
    public class Objeto
    {
        private int _lado;
        private int _perimetro;
        private int _apotema;
        private TipodeBorde tipodeBorde;

        public TipodeBorde TipoDeBorde
        {
            get { return tipodeBorde; }
            set { tipodeBorde = value; }
        }
        private ColorRelleno colorRelleno;

        public ColorRelleno ColorRelleno
        {
            get { return colorRelleno; }
            set { colorRelleno = value; }
        }

        public Objeto(int lado, TipodeBorde borde, ColorRelleno color)
        {
            _lado = lado;
            TipoDeBorde = borde;
            ColorRelleno = color;
        }

        public Objeto()
        {

        }

        public int GetLado() => _lado;
        public void SetLado(int lado)
        {
            if (lado > 0)
            {
                _lado = lado;
            }
        }

        //Acá van características obtenidas de la medida ingresada:

        public double GetApotema() => Math.Sqrt(Math.Pow(_lado, 2) - Math.Pow(_lado / 2, 2));

        public double GetPerimetro() => _lado * 5;
        public double GetArea() => (GetPerimetro() * GetApotema()) / 2;

    }
}