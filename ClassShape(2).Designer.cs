namespace Mod_2
{
    partial class ClassShape_2_
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
            Button_Circle = new Button();
            Button_Rectangle = new Button();
            panel1 = new Panel();
            buttonCircle_calc = new Button();
            textBox_Radius = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_Width = new TextBox();
            buttonRectangle_calc = new Button();
            label3 = new Label();
            textBox_Length = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            textBox_Perimetr = new TextBox();
            textBox_Area = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Circle
            // 
            Button_Circle.Location = new Point(19, 23);
            Button_Circle.Name = "Button_Circle";
            Button_Circle.Size = new Size(197, 56);
            Button_Circle.TabIndex = 0;
            Button_Circle.Text = "Создать объект типа \"Круг\"";
            Button_Circle.UseVisualStyleBackColor = true;
            Button_Circle.Click += Button_Circle_Click;
            // 
            // Button_Rectangle
            // 
            Button_Rectangle.Location = new Point(222, 23);
            Button_Rectangle.Name = "Button_Rectangle";
            Button_Rectangle.Size = new Size(197, 56);
            Button_Rectangle.TabIndex = 1;
            Button_Rectangle.Text = "Создать объект типа \"Прямоугольник\"";
            Button_Rectangle.UseVisualStyleBackColor = true;
            Button_Rectangle.Click += Button_Rectangle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCircle_calc);
            panel1.Controls.Add(textBox_Radius);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 79);
            panel1.TabIndex = 2;
            // 
            // buttonCircle_calc
            // 
            buttonCircle_calc.Enabled = false;
            buttonCircle_calc.Location = new Point(3, 46);
            buttonCircle_calc.Name = "buttonCircle_calc";
            buttonCircle_calc.Size = new Size(182, 23);
            buttonCircle_calc.TabIndex = 5;
            buttonCircle_calc.Text = "Вычислить";
            buttonCircle_calc.UseVisualStyleBackColor = true;
            buttonCircle_calc.Click += buttonCircle_calc_Click;
            // 
            // textBox_Radius
            // 
            textBox_Radius.Enabled = false;
            textBox_Radius.Location = new Point(54, 10);
            textBox_Radius.Name = "textBox_Radius";
            textBox_Radius.Size = new Size(131, 23);
            textBox_Radius.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Радиус";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 13);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Ширина";
            // 
            // textBox_Width
            // 
            textBox_Width.Enabled = false;
            textBox_Width.Location = new Point(63, 10);
            textBox_Width.Name = "textBox_Width";
            textBox_Width.Size = new Size(131, 23);
            textBox_Width.TabIndex = 4;
            // 
            // buttonRectangle_calc
            // 
            buttonRectangle_calc.Enabled = false;
            buttonRectangle_calc.Location = new Point(3, 76);
            buttonRectangle_calc.Name = "buttonRectangle_calc";
            buttonRectangle_calc.Size = new Size(191, 23);
            buttonRectangle_calc.TabIndex = 5;
            buttonRectangle_calc.Text = "Вычислить";
            buttonRectangle_calc.UseVisualStyleBackColor = true;
            buttonRectangle_calc.Click += buttonRectangle_calc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 42);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Длина";
            // 
            // textBox_Length
            // 
            textBox_Length.Enabled = false;
            textBox_Length.Location = new Point(63, 39);
            textBox_Length.Name = "textBox_Length";
            textBox_Length.Size = new Size(131, 23);
            textBox_Length.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(buttonRectangle_calc);
            panel2.Controls.Add(textBox_Length);
            panel2.Controls.Add(textBox_Width);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(222, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 109);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 226);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Площадь";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 256);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "Периметр";
            // 
            // textBox_Perimetr
            // 
            textBox_Perimetr.Enabled = false;
            textBox_Perimetr.Location = new Point(196, 253);
            textBox_Perimetr.Name = "textBox_Perimetr";
            textBox_Perimetr.Size = new Size(131, 23);
            textBox_Perimetr.TabIndex = 9;
            // 
            // textBox_Area
            // 
            textBox_Area.Enabled = false;
            textBox_Area.Location = new Point(196, 223);
            textBox_Area.Name = "textBox_Area";
            textBox_Area.Size = new Size(131, 23);
            textBox_Area.TabIndex = 8;
            // 
            // ClassShape_2_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 293);
            Controls.Add(textBox_Perimetr);
            Controls.Add(textBox_Area);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Button_Rectangle);
            Controls.Add(Button_Circle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClassShape_2_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassShape(2)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_Circle;
        private Button Button_Rectangle;
        private Panel panel1;
        private Button buttonCircle_calc;
        private TextBox textBox_Radius;
        private Label label1;
        private Label label2;
        private TextBox textBox_Width;
        private Button buttonRectangle_calc;
        private Label label3;
        private TextBox textBox_Length;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private TextBox textBox_Perimetr;
        private TextBox textBox_Area;


    }
}