using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularPerimetro
{
    public partial class Form1 : Form
    {
        #region atributtes, propierties and constructor
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Events
        //Buttons
        /// <summary>
        /// When click on Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(Convert.ToSingle(tbxTriangleBase.Text), Convert.ToSingle(tbxTriangleHeight.Text));
            lblTriangleAreaSolution.Text = "Area = " + triangle.CalculateArea().ToString();
            lblPermimeterTriangleSolution.Text = "Perimeter = " + triangle.CalculatePerimeter().ToString();   
        }
        /// <summary>
        /// When click on Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Convert.ToSingle(tbxCircleRadio.Text));

            lblPerimeterCircleSolution.Text = "Perimeter = " + circle.CalculatePerimeter().ToString();
            lblCircleAreaSolution.Text = "Area = " + circle.CalculateArea().ToString();
        }
        /// <summary>
        /// When click on Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(Convert.ToSingle(tbxRectangleBase.Text), Convert.ToSingle(tbxRectangleHeight.Text));

            lblRectanglePerimeterSolution.Text = "Perimeter = " + rectangle.CalculatePerimeter().ToString();
            lblRectangleAreaSolution.Text = "Area = " + rectangle.CalculateArea().ToString();
           
        }

        //TextBox
        /// <summary>
        /// When text box change enable or disable button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxTriangleBase_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(tbxTriangleHeight,tbxTriangleBase,btnTriangle);
        }
        /// <summary>
        /// When text box change enable or disable button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxTriangleHeight_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(tbxTriangleHeight, tbxTriangleBase, btnTriangle);
        }
        /// <summary>
        /// When text box change enable or disable button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxCircleRadio_TextChanged(object sender, EventArgs e)
        {
            EnableBtnCircle(tbxCircleRadio);
        }
        /// <summary>
        /// When text box change enable or disable button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxRectangleBase_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(tbxRectangleBase, tbxRectangleHeight, btnRectangle);
        }
        /// <summary>
        /// When text box change enable or disable button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxRectangleHeight_TextChanged(object sender, EventArgs e)
        {
            EnableBtn(tbxRectangleBase, tbxRectangleHeight, btnRectangle);
        }
        #endregion

        #region AuxMethods
        /// <summary>
        /// Enable button when text box is not empty
        /// </summary>
        /// <param name="bases"></param>
        /// <param name="height"></param>
        /// <param name="button"></param>
        private void EnableBtn(TextBox bases ,TextBox height, Button button)
        {
            if (string.IsNullOrEmpty(bases.Text) || string.IsNullOrEmpty(height.Text))
            {
                button.Enabled = false;
            }
            else
            {
               button.Enabled = true;
            }
        }
        /// <summary>
        /// Enable button when text box is not empty
        /// </summary>
        /// <param name="radio"></param>
        private void EnableBtnCircle(TextBox radio)
        {
            if (string.IsNullOrEmpty(radio.Text))
            {
                btnCircle.Enabled = false;
            }
            else
            {
                btnCircle.Enabled = true;
            }
        }
        #endregion

    }
}
