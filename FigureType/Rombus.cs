namespace GeometricalFigure.FigureType
{
    public class Rhombus : Figure
    {
        private readonly float _sideFirst;
        private readonly float _sideSecond;

        public Rhombus(float sideFirst, float sideSecond, string name)
        {
            _sideFirst = sideFirst;
            _sideSecond = sideSecond;
            Name = name;
        }

        public override void AreaCalculation()
        {
            Area = 0.5f * _sideFirst * _sideSecond;
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = _sideFirst * _sideSecond;
            base.PerimeterCalculation();
        }

    }
}
