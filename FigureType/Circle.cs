namespace GeometricalFigure.FigureType
{
    public class Circle : Figure
    {
        private readonly float _radius;
        private const float Pi = 3.14f;

        public Circle(float radius, string name)
        {
            _radius = radius;
            Name = name;
        }
        public override void AreaCalculation()
        {
            Area = Pi * (_radius * _radius);
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = 2 * Pi * _radius;
            base.PerimeterCalculation();
        }

    }
}
