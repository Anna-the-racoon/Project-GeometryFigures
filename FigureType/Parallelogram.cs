namespace GeometricalFigure.FigureType
{
    public class Parallelogram : Figure
    {
        private readonly float _sideSmall;
        private readonly float _sideLong;

        public Parallelogram(float sideSmall, float sideLong, string name)
        {
            _sideSmall = sideSmall;
            _sideLong = sideLong;
            Name = name;
        }
        public override void AreaCalculation()
        {
            Area = _sideLong * _sideSmall;
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = 2*(_sideLong + _sideSmall);
            base.PerimeterCalculation();
        }

    }
}
