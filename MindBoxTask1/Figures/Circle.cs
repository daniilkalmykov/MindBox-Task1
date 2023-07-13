using System;
using MindBoxTask1.Interfaces;

namespace MindBoxTask1.Figures
{
    public sealed class Circle : IFigure
    {
        private readonly float _radius;

        public Circle(float radius)
        {
            if (radius <= 0)
                throw new ArgumentNullException();
            
            _radius = radius;
        }

        public float GetArea()
        {
            return (float)(Math.PI * _radius * _radius);
        }
    }
}