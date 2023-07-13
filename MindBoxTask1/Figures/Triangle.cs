using System;
using System.Collections.Generic;
using System.Linq;
using MindBoxTask1.Interfaces;

namespace MindBoxTask1.Figures
{
    public sealed class Triangle : IFigure
    {
        private const int SidesCount = 3;
        
        private readonly List<Side> _sides;

        public Triangle(List<Side> sides)
        {
            if (sides.Count != SidesCount)
                throw new ArgumentNullException();
            
            _sides = sides;
        }

        public float GetArea()
        {
            var semiPerimeter = _sides.Aggregate<Side, float>(0, (current, side) => current + side.Length) / 2;
            var area = _sides.Aggregate<Side, float>(1, (current, side) => current * (semiPerimeter - side.Length));

            area = (float)Math.Sqrt(area * semiPerimeter);
            
            return area;
        }
    }
}