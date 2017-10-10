using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    class Rectangle:Figure
    {
        #region ATTRIBUTES
        /// <summary>
        /// Rectangle base attribute
        /// </summary>
        private float baseRectangle;
        /// <summary>
        /// Rectangle height attribute
        /// </summary>
        private float height;
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Rectangle base property
        /// </summary> 
        public float BaseRectanlge
        {
            get
            {
                return baseRectangle;
            }
            set
            {
                baseRectangle = value;
            }
        }
        /// <summary>
        /// Rectangle Height property
        /// </summary>
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
        /// <param name="baseRectangle"></param>
        /// <param name="height"></param>
        public Rectangle(float baseRectangle, float height)
        {
            BaseRectanlge = baseRectangle;
        }
        /// <summary>
        /// Calculate perimeter
        /// </summary>
        /// <returns>Return float perimeter</returns>
        public override float CalculatePerimeter()
        {
            return 3 * baseRectangle;
        }
        /// <summary>
        /// Calculate area
        /// </summary>
        /// <returns>Return float area</returns>
        public override float CalculateArea()
        {
            return baseRectangle * Perimeter / 2;
        }
        #endregion

    }
}
