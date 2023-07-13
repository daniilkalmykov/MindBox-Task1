using System;

namespace MindBoxTask1.Figures
{
    public sealed class Side
    {
        public Side(int length)
        {
            if (Length <= 0)
                throw new ArgumentNullException();
            
            Length = length;
        }
        
        public int Length { get; private set; }
    }
}