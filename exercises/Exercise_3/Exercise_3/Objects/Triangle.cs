using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Objects
{
    public class Triangle : Shape
    {
        #region Fields
        protected double h;
        #endregion

        #region Constructs
        public Triangle(string backgroundColor, string borderColor, double a, double h = 0)
            : base(backgroundColor, borderColor, a)
        {
            this.h = h;
        }
        #endregion

        #region Methods
        public override double CalcPerimeter()
        {
            return a * 3;
        }

        public override double CalcArea()
        {
            return (a * h) / 2;
        }
        #endregion
    }
}
