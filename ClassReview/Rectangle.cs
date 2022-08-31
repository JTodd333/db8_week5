using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReview
{
    //Change internal to public
    public class Rectangle
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }

        public Rectangle(decimal _Length, decimal _Width)
        {
            Length = _Length;  
            Width = _Width;
        }

        public decimal Perim()
        {
            return 2 * Length + 2 * Width;
        }
        public decimal Area()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return $"Rectangle: Length {Length}, Width {Width}";
        }
    }
}
