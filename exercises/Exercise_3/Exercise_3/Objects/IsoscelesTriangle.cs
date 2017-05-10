using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Objects
{
    public class IsoscelesTriangle : Triangle
    {
        #region Fields
        private double c;
        #endregion

        #region Constructors
        public IsoscelesTriangle(string backgroundColor, string borderColor, double a, double c)
            : base(backgroundColor, borderColor, a)
        {
            this.c = c;
        }
        #endregion

        #region Methods
        public override double CalcPerimeter()
        {
            return a + (2 * c);
        }
        #endregion
    }
}
