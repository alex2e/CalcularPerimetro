using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    class Circle:Figure
    {

        #region ATTRIBUTES
        /// <summary>
        /// Circle radio attribute
        /// </summary>
        private float radioCircle;
        #endregion
        /// <summary>
        /// Pi Number
        /// </summary>
        private const double PI = Math.PI;

        #region PROPERTIES
        /// <summary>
        /// Circle base property
        /// </summary>
        /// <remarks>TODO</remarks>
        public float RadioCircle
        {
            get
            {
                return radioCircle;
            }
            set
            {
                radioCircle = value;
            }
        }

        #endregion

        #region METHODS
        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="baseTriangle"></param>
        /// <param name="height"></param>
        public Circle(float radio)
        {
            RadioCircle = radio;
        }
        /// <summary>
        /// Calculate perimeter
        /// </summary>
        /// <returns>Return float perimeter</returns>
        public override float CalculatePerimeter()
        {
            return 2 * (float) PI * RadioCircle;
        }
        /// <summary>
        /// Calculate area
        /// </summary>
        /// <returns>Return float area</returns>
        public override float CalculateArea()
        {
            return (float) PI * RadioCircle * RadioCircle / 2;
        }
        #endregion

    }
}
