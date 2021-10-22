namespace GeometricalFigure.FigureType
{
    public class Rectangle : Figure
    {
        private readonly float _sideSmall;
        private readonly float _sideLong;

        public Rectangle(float sideSmall, float sideLong, string name)
        {
            _sideSmall = sideSmall;
            _sideLong = sideLong;
            Name = name;
        }

        public override void AreaCalculation()
        {
            Area = _sideSmall * _sideLong;
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = (_sideSmall + _sideLong) * 2;
            base.PerimeterCalculation();
        }

    }
}
