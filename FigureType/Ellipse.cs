using System;

namespace GeometricalFigure.FigureType
{
    public class Ellipse : Figure
    {
        private readonly float _smallRadius;
        private readonly float _longRadius;
        private readonly float _pi = 3.14f;
        
        public Ellipse(float smallRadius, float longRadius, string name)
        {
            this._smallRadius = smallRadius;
            this._longRadius = longRadius;
            this.Name = name;
        }

        public override void AreaCalculation()
        {
            Area = _pi * _smallRadius * _longRadius;
            base.AreaCalculation();
        }
        public override void PerimeterCalculation()
        {
            Perimeter = 2 * _pi * (float)Math.Sqrt((_smallRadius * _smallRadius + _longRadius * _longRadius) * 2);
            base.PerimeterCalculation();
        }

    }
}
