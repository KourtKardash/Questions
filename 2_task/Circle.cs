using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public interface Shape
    {
        double GetSquare();
    }
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius) 
        {
            if (_radius <= 0)
            {
                throw new ArgumentException("Радиус круга должен быть строго больше ноля.");
            }
            _radius = radius;
        }
        public double GetSquare()
        {
            return Math.PI * _radius * _radius;
        }
    }
    public class Triangle : Shape
    {
        private double _side1, _side2, _side3;
        public  Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        public double GetSquare()
        {
            if (_side1 <= 0 || _side2 <= 0 || _side3 <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть строго больше ноля.");
            }
            if(!(_side1 + _side2 > _side3 && _side2 + _side3 > _side1 && _side1 + _side3 > _side2))
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует.");
            }
            double p = 0.5 * (_side1 + _side2 + _side3);
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }
        public bool IsRight()
        {
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);
            if (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
            {
                return true;
            }
            return false;
        }
    }
}
