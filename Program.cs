using GeometricalFigure.FigureType;
using System;

namespace GeometricalFigure
{
    internal static class Program
    {
        static void Main()
        {
            int figureNumber;
            float a;
            float b;
            float c;

            do
            {
                Console.WriteLine("Выбирите фигуру:" +
                               "\n1.Треугольник;" +
                               "\n2.Квадрат" +
                               "\n3.Ромб" +
                               "\n4.Прямогольник" +
                               "\n5.Параллелограмм" +
                               "\n6.Трапеция" +
                               "\n7.Круг" +
                               "\n8.Эллипс" +
                               "\n0.Выход");
                figureNumber = Convert.ToInt32(Console.ReadLine());
                if (figureNumber<0 || figureNumber>9)
                {
                    Console.WriteLine("ОШИБКА! Неверно введен номер фигуры");
                }

                switch (figureNumber)
                {
                    case 1:
                        Console.Write("Введите размеры сторон:\nПервая сторона =");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Второя сторона = ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Третья сторона = ");
                        c = float.Parse(Console.ReadLine());

                        var triangle = new Triangle(a, b, c, "треугольник");
                        triangle.AreaCalculation();
                        triangle.PerimeterCalculation();
                        break;

                    case 2:
                        Console.Write("Введите размеры стороны =");
                        a = float.Parse(Console.ReadLine());

                        var square = new Square(a, "квадрат");
                        square.AreaCalculation();
                        square.PerimeterCalculation();
                        break;

                    case 3:
                        Console.Write("Введите размеры сторон одной параллели=");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размеры сторон второй параллели= ");
                        b = float.Parse(Console.ReadLine());

                        var rhombus = new Rhombus(a, b, "ромб");
                        rhombus.AreaCalculation();
                        rhombus.PerimeterCalculation();
                        break;

                    case 4:
                        Console.Write("Введите размеры сторон =");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размеры оснований = ");
                        b = float.Parse(Console.ReadLine());

                        var rectangle = new Rectangle(a, b, "прямоугольник");
                        rectangle.AreaCalculation();
                        rectangle.PerimeterCalculation();
                        break;

                    case 5:
                        Console.Write("Введите размеры основания =");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размер боковых сторон = ");
                        b = float.Parse(Console.ReadLine());

                        var parallelogram = new Parallelogram(a, b, "параллелограмм");
                        parallelogram.AreaCalculation();
                        parallelogram.PerimeterCalculation();
                        break;

                    case 6:
                        Console.Write("Введите размеры меньшего основания =");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размер большего основания = ");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размер боковой стороны = ");
                        c = float.Parse(Console.ReadLine());

                        if (a>b)
                        {
                            Console.WriteLine("ОШИБКА! Неверно введены размеры оснований");
                            break;
                        }

                        var trapeze = new Trapeze(a, b, c, "трапеция");
                        trapeze.AreaCalculation();
                        trapeze.PerimeterCalculation();

                        break;

                    case 7:
                        Console.Write("Введите размеры радиуса =");
                        a = float.Parse(Console.ReadLine());

                        var circle = new Circle(a, "круг");
                        circle.AreaCalculation();
                        circle.PerimeterCalculation();
                        break;

                    case 8:
                        Console.Write("Введите размеры меньшего радуиса =");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размер большего радиуса = ");
                        b = float.Parse(Console.ReadLine());

                        if (a>b)
                        {
                            Console.WriteLine("ОШИБКА! Неверно введены размеры радиуса");
                            break;
                        }

                        var ellipse = new Ellipse(a, b, "элипс");
                        ellipse.AreaCalculation();
                        ellipse.PerimeterCalculation();
                        break;
                }

                Console.WriteLine();

            } while (figureNumber != 0);

            Console.ReadLine();
        }
    }
}
