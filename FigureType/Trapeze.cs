using System;

namespace GeometricalFigure.FigureType
{
    public class Trapeze : Figure
    {
        private readonly float _smallFooting;
        private readonly float _bigFooting;
        private readonly float _side;

        public Trapeze(float smallFooting, float bigFooting, float side, string name)
        {
            _smallFooting = smallFooting;
            _bigFooting = bigFooting;
            _side = side;
            Name = name;
        }
        public override void AreaCalculation()
        {
            Area = (float)Math.Sqrt((_bigFooting - _smallFooting) / 2 * _side);
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = 2 * _side + _smallFooting + _bigFooting;
            base.PerimeterCalculation();
        }

    }
}
