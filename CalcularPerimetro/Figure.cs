using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    class Figure
    {
        #region ATTRIBUTES
        private float perimeter;
        private float area;
        #endregion

        #region PROPERTIES
        public float Perimeter
        {
            get
            {
                return perimeter;
            }
            set
            {
                perimeter = value;
            }
        }
        public float Area
        {
            get
            {
                return area;   
            }
            set
            {
                area = value;
            }
        }
        #endregion

        #region METHODS
        public virtual float CalculatePerimeter()
        {
            return 0;
        }
        public virtual float CalculateArea()
        {
            return 0;
        }
        #endregion


    }
}
