using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO.Objects
{
    public class Cat
    {
        #region Fields
        protected string name;
        protected double weight;
        protected string color;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Contstructos
        public Cat() { }
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Cat(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
        #endregion
    }
}