using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO.Objects
{
    public class Lion : Cat
    {
        #region Constructors
        public Lion() { }
        public Lion(string name, string color, double weight)
            : base(name, color)
        {
            this.weight = weight;
        }
        #endregion

        #region Methods
        public void Hello()
        {
            string result = "Hello my name is " + name;
            Console.WriteLine(result);
        }
        #endregion
    }
}