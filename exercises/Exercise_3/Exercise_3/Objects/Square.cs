using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Objects
{
    public class Square : Shape
    {
        #region Constructors
        public Square(string backgroundColor, string borderColor, double a)
            : base(backgroundColor, borderColor, a) { }
        #endregion

        #region Methods
        public override double CalcPerimeter()
        {
            return a * 4;
        }
        #endregion
    }
}
