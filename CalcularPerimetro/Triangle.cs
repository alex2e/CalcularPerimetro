using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    class Triangle:Figure
    {
        #region ATTRIBUTES
        /// <summary>
        /// Triangle base attribute
        /// </summary>
        private float baseTriangle;
        /// <summary>
        /// Triangle height attribute
        /// </summary>
        private float height;
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Triangle base property
        /// </summary>
        /// <remarks>TODO</remarks>
        public float BaseTriangle
        {
            get
            {
                return baseTriangle;
            }
            set
            {
                baseTriangle = value;
            }
        }
        public float Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="baseTriangle"></param>
        /// <param name="height"></param>
        public Triangle(float baseTriangle, float height)
        {
            BaseTriangle = baseTriangle;
        }
        /// <summary>
        /// Calculate perimeter
        /// </summary>
        /// <returns>Return float perimeter</returns>
        public override float CalculatePerimeter()
        {
            return 3*baseTriangle;
        }
        /// <summary>
        /// Calculate area
        /// </summary>
        /// <returns>Return float area</returns>
        public override float CalculateArea()
        {
            return baseTriangle*Perimeter/2;
        }
        #endregion

    }
}
