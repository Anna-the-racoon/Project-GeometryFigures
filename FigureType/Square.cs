namespace GeometricalFigure.FigureType
{
    public class Square : Figure
    {
        private readonly float _side;

        public Square(float side, string name)
        {
            _side = side;
            Name = name;
        }

        public override void AreaCalculation()
        {
            Area = _side * _side;
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = (_side + _side) * 2;
            base.PerimeterCalculation();
        }

    }
}
