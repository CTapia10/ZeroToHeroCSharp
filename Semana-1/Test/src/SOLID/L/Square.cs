using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.SOLID.L
{
    // public class Square : Rectangle
    // {
    //     public override double Width {
    //         get => base.Width;
    //         set => base.Width = base.Height = value;
    //     }
    //     public override double Height {
    //         get => base.Height;
    //         set => base.Height = base.Width = value;
    //     }
    // }
        public class Square : Shape
    {
    public double SideLength {get; set;}
        public override double Area => SideLength*SideLength;
    }
}