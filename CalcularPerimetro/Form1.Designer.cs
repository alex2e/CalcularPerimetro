namespace CalcularPerimetro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTriangleBase = new System.Windows.Forms.Label();
            this.lbltriangleHeight = new System.Windows.Forms.Label();
            this.tbxTriangleBase = new System.Windows.Forms.TextBox();
            this.tbxTriangleHeight = new System.Windows.Forms.TextBox();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.lblCircleRadio = new System.Windows.Forms.Label();
            this.lblRantangleBase = new System.Windows.Forms.Label();
            this.lblRectagleHeight = new System.Windows.Forms.Label();
            this.tbxCircleRadio = new System.Windows.Forms.TextBox();
            this.tbxRectangleBase = new System.Windows.Forms.TextBox();
            this.tbxRectangleHeight = new System.Windows.Forms.TextBox();
            this.lblPermimeterTriangleSolution = new System.Windows.Forms.Label();
            this.lblTriangleAreaSolution = new System.Windows.Forms.Label();
            this.lblCircleAreaSolution = new System.Windows.Forms.Label();
            this.lblPerimeterCircleSolution = new System.Windows.Forms.Label();
            this.lblRectangleAreaSolution = new System.Windows.Forms.Label();
            this.lblRectanglePerimeterSolution = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTriangleBase
            // 
            this.lblTriangleBase.AutoSize = true;
            this.lblTriangleBase.Location = new System.Drawing.Point(159, 61);
            this.lblTriangleBase.Name = "lblTriangleBase";
            this.lblTriangleBase.Size = new System.Drawing.Size(40, 17);
            this.lblTriangleBase.TabIndex = 3;
            this.lblTriangleBase.Text = "Base";
            // 
            // lbltriangleHeight
            // 
            this.lbltriangleHeight.AutoSize = true;
            this.lbltriangleHeight.Location = new System.Drawing.Point(159, 141);
            this.lbltriangleHeight.Name = "lbltriangleHeight";
            this.lbltriangleHeight.Size = new System.Drawing.Size(49, 17);
            this.lbltriangleHeight.TabIndex = 4;
            this.lbltriangleHeight.Text = "Height";
            // 
            // tbxTriangleBase
            // 
            this.tbxTriangleBase.Location = new System.Drawing.Point(162, 81);
            this.tbxTriangleBase.Name = "tbxTriangleBase";
            this.tbxTriangleBase.Size = new System.Drawing.Size(100, 22);
            this.tbxTriangleBase.TabIndex = 5;
            this.tbxTriangleBase.TextChanged += new System.EventHandler(this.tbxTriangleBase_TextChanged);
            // 
            // tbxTriangleHeight
            // 
            this.tbxTriangleHeight.Location = new System.Drawing.Point(162, 161);
            this.tbxTriangleHeight.Name = "tbxTriangleHeight";
            this.tbxTriangleHeight.Size = new System.Drawing.Size(100, 22);
            this.tbxTriangleHeight.TabIndex = 6;
            this.tbxTriangleHeight.TextChanged += new System.EventHandler(this.tbxTriangleHeight_TextChanged);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Enabled = false;
            this.btnTriangle.Location = new System.Drawing.Point(284, 116);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(100, 30);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "CALCULE";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Enabled = false;
            this.btnCircle.Location = new System.Drawing.Point(284, 279);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(100, 30);
            this.btnCircle.TabIndex = 7;
            this.btnCircle.Text = "CALCULE";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Enabled = false;
            this.btnRectangle.Location = new System.Drawing.Point(284, 446);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(100, 30);
            this.btnRectangle.TabIndex = 8;
            this.btnRectangle.Text = "CALCULE";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // lblCircleRadio
            // 
            this.lblCircleRadio.AutoSize = true;
            this.lblCircleRadio.Location = new System.Drawing.Point(159, 263);
            this.lblCircleRadio.Name = "lblCircleRadio";
            this.lblCircleRadio.Size = new System.Drawing.Size(45, 17);
            this.lblCircleRadio.TabIndex = 9;
            this.lblCircleRadio.Text = "Radio";
            // 
            // lblRantangleBase
            // 
            this.lblRantangleBase.AutoSize = true;
            this.lblRantangleBase.Location = new System.Drawing.Point(159, 392);
            this.lblRantangleBase.Name = "lblRantangleBase";
            this.lblRantangleBase.Size = new System.Drawing.Size(40, 17);
            this.lblRantangleBase.TabIndex = 10;
            this.lblRantangleBase.Text = "Base";
            // 
            // lblRectagleHeight
            // 
            this.lblRectagleHeight.AutoSize = true;
            this.lblRectagleHeight.Location = new System.Drawing.Point(159, 475);
            this.lblRectagleHeight.Name = "lblRectagleHeight";
            this.lblRectagleHeight.Size = new System.Drawing.Size(49, 17);
            this.lblRectagleHeight.TabIndex = 11;
            this.lblRectagleHeight.Text = "Height";
            // 
            // tbxCircleRadio
            // 
            this.tbxCircleRadio.Location = new System.Drawing.Point(162, 283);
            this.tbxCircleRadio.Name = "tbxCircleRadio";
            this.tbxCircleRadio.Size = new System.Drawing.Size(100, 22);
            this.tbxCircleRadio.TabIndex = 12;
            this.tbxCircleRadio.TextChanged += new System.EventHandler(this.tbxCircleRadio_TextChanged);
            // 
            // tbxRectangleBase
            // 
            this.tbxRectangleBase.Location = new System.Drawing.Point(162, 412);
            this.tbxRectangleBase.Name = "tbxRectangleBase";
            this.tbxRectangleBase.Size = new System.Drawing.Size(100, 22);
            this.tbxRectangleBase.TabIndex = 13;
            this.tbxRectangleBase.TextChanged += new System.EventHandler(this.tbxRectangleBase_TextChanged);
            // 
            // tbxRectangleHeight
            // 
            this.tbxRectangleHeight.Location = new System.Drawing.Point(162, 495);
            this.tbxRectangleHeight.Name = "tbxRectangleHeight";
            this.tbxRectangleHeight.Size = new System.Drawing.Size(100, 22);
            this.tbxRectangleHeight.TabIndex = 14;
            this.tbxRectangleHeight.TextChanged += new System.EventHandler(this.tbxRectangleHeight_TextChanged);
            // 
            // lblPermimeterTriangleSolution
            // 
            this.lblPermimeterTriangleSolution.AutoSize = true;
            this.lblPermimeterTriangleSolution.Location = new System.Drawing.Point(414, 81);
            this.lblPermimeterTriangleSolution.Name = "lblPermimeterTriangleSolution";
            this.lblPermimeterTriangleSolution.Size = new System.Drawing.Size(85, 17);
            this.lblPermimeterTriangleSolution.TabIndex = 15;
            this.lblPermimeterTriangleSolution.Text = "Perimeter = ";
            // 
            // lblTriangleAreaSolution
            // 
            this.lblTriangleAreaSolution.AutoSize = true;
            this.lblTriangleAreaSolution.Location = new System.Drawing.Point(414, 161);
            this.lblTriangleAreaSolution.Name = "lblTriangleAreaSolution";
            this.lblTriangleAreaSolution.Size = new System.Drawing.Size(50, 17);
            this.lblTriangleAreaSolution.TabIndex = 16;
            this.lblTriangleAreaSolution.Text = "Area =";
            // 
            // lblCircleAreaSolution
            // 
            this.lblCircleAreaSolution.AutoSize = true;
            this.lblCircleAreaSolution.Location = new System.Drawing.Point(414, 319);
            this.lblCircleAreaSolution.Name = "lblCircleAreaSolution";
            this.lblCircleAreaSolution.Size = new System.Drawing.Size(54, 17);
            this.lblCircleAreaSolution.TabIndex = 18;
            this.lblCircleAreaSolution.Text = "Area = ";
            // 
            // lblPerimeterCircleSolution
            // 
            this.lblPerimeterCircleSolution.AutoSize = true;
            this.lblPerimeterCircleSolution.Location = new System.Drawing.Point(414, 239);
            this.lblPerimeterCircleSolution.Name = "lblPerimeterCircleSolution";
            this.lblPerimeterCircleSolution.Size = new System.Drawing.Size(85, 17);
            this.lblPerimeterCircleSolution.TabIndex = 17;
            this.lblPerimeterCircleSolution.Text = "Perimeter = ";
            // 
            // lblRectangleAreaSolution
            // 
            this.lblRectangleAreaSolution.AutoSize = true;
            this.lblRectangleAreaSolution.Location = new System.Drawing.Point(414, 495);
            this.lblRectangleAreaSolution.Name = "lblRectangleAreaSolution";
            this.lblRectangleAreaSolution.Size = new System.Drawing.Size(54, 17);
            this.lblRectangleAreaSolution.TabIndex = 20;
            this.lblRectangleAreaSolution.Text = "Area = ";
            // 
            // lblRectanglePerimeterSolution
            // 
            this.lblRectanglePerimeterSolution.AutoSize = true;
            this.lblRectanglePerimeterSolution.Location = new System.Drawing.Point(414, 415);
            this.lblRectanglePerimeterSolution.Name = "lblRectanglePerimeterSolution";
            this.lblRectanglePerimeterSolution.Size = new System.Drawing.Size(81, 17);
            this.lblRectanglePerimeterSolution.TabIndex = 19;
            this.lblRectanglePerimeterSolution.Text = "Perimeter =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "TRIANGULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "CIRCLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "RECTANGE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRectangleAreaSolution);
            this.Controls.Add(this.lblRectanglePerimeterSolution);
            this.Controls.Add(this.lblCircleAreaSolution);
            this.Controls.Add(this.lblPerimeterCircleSolution);
            this.Controls.Add(this.lblTriangleAreaSolution);
            this.Controls.Add(this.lblPermimeterTriangleSolution);
            this.Controls.Add(this.tbxRectangleHeight);
            this.Controls.Add(this.tbxRectangleBase);
            this.Controls.Add(this.tbxCircleRadio);
            this.Controls.Add(this.lblRectagleHeight);
            this.Controls.Add(this.lblRantangleBase);
            this.Controls.Add(this.lblCircleRadio);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.tbxTriangleHeight);
            this.Controls.Add(this.tbxTriangleBase);
            this.Controls.Add(this.lbltriangleHeight);
            this.Controls.Add(this.lblTriangleBase);
            this.Controls.Add(this.btnTriangle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Perimeter and Area";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTriangleBase;
        private System.Windows.Forms.Label lbltriangleHeight;
        private System.Windows.Forms.TextBox tbxTriangleBase;
        private System.Windows.Forms.TextBox tbxTriangleHeight;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Label lblCircleRadio;
        private System.Windows.Forms.Label lblRantangleBase;
        private System.Windows.Forms.Label lblRectagleHeight;
        private System.Windows.Forms.TextBox tbxCircleRadio;
        private System.Windows.Forms.TextBox tbxRectangleBase;
        private System.Windows.Forms.TextBox tbxRectangleHeight;
        private System.Windows.Forms.Label lblPermimeterTriangleSolution;
        private System.Windows.Forms.Label lblTriangleAreaSolution;
        private System.Windows.Forms.Label lblCircleAreaSolution;
        private System.Windows.Forms.Label lblPerimeterCircleSolution;
        private System.Windows.Forms.Label lblRectangleAreaSolution;
        private System.Windows.Forms.Label lblRectanglePerimeterSolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

