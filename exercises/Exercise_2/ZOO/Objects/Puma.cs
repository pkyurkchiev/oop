using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO.Objects
{
    public class Puma : Cat
    {
        #region Properties
        public bool IsWhite { get { return this.color == "white"; } }
        #endregion

        #region Constructors
        public Puma() { }
        public Puma(string name, double weight)
            : base(name, weight)
        {
            Random random = new Random();
            int prediction = random.Next(0, 100);
            if (prediction == 1)
            {
                this.color = "white";
            }
            else
            {
                this.color = "black";
            }
        }
        #endregion

        #region Methods
        public string Information()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + this.name);
            sb.AppendLine("Color: " + this.color);
            sb.AppendLine("Weight: " + this.weight);

            return sb.ToString();
        }
        #endregion
    }
}