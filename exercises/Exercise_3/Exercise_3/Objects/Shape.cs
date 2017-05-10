using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Objects
{
    public abstract class Shape
    {
        #region Fields
        private string backgroundColor;
        private string borderColor;
        protected double a;
        #endregion

        #region Proterties
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        #endregion

        #region Constructors
        public Shape(string backgroundColor, string borderColor, double a)
        {
            this.backgroundColor = backgroundColor;
            this.borderColor = borderColor;
            this.a = a;
        }
        #endregion

        #region Methods
        public abstract double CalcPerimeter();

        public virtual double CalcArea()
        {
            return a * a;
        }
        #endregion
    }
}
