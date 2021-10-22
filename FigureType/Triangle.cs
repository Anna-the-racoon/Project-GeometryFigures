using System;

namespace GeometricalFigure.FigureType
{
    public class Triangle : Figure
    {
        private readonly float _bottom;
        private readonly float _left;
        private readonly float _right;

        public Triangle(float bottom, float left, float right, string name)
        {
            _bottom = bottom;
            _left = left;
            _right = right;
            Name = name;
        }

        public override void AreaCalculation()
        {
            Area = (float)Math.Sqrt(Perimeter * (Perimeter - _bottom) * (Perimeter - _left) * (Perimeter - _right));
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = (_bottom + _left + _right) / 2;
            base.PerimeterCalculation();
        }


    }
}
