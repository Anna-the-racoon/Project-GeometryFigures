using System;

namespace GeometricalFigure
{
    public abstract class Figure
    {
        protected string Name { get; set; }

        protected float Area { get; set; }
        protected float Perimeter { get; set; }


        public virtual void AreaCalculation()
        {
            Console.WriteLine($"Площадь {Name} составляет - {Area}");
        }
        public virtual void PerimeterCalculation()
        {
            Console.WriteLine($"Периметр {Name} составляет - {Perimeter}");
        }
    }
}
