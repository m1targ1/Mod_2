namespace Mod_2
{
    partial class Drawable_4_
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
            panel1 = new Panel();
            textBox_radius = new TextBox();
            label1 = new Label();
            draw_Circle = new Button();
            Drawing = new Button();
            draw_Rectangle = new Button();
            panel2 = new Panel();
            textBox_length = new TextBox();
            label3 = new Label();
            textBox_width = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            textBox_triangle3 = new TextBox();
            textBox_triangle1 = new TextBox();
            textBox_triangle2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            draw_Triangle = new Button();
            panel_drawing = new Panel();
            textBox_info = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_radius);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 50);
            panel1.TabIndex = 0;
            // 
            // textBox_radius
            // 
            textBox_radius.Location = new Point(2, 21);
            textBox_radius.Name = "textBox_radius";
            textBox_radius.Size = new Size(194, 23);
            textBox_radius.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите радиус";
            // 
            // draw_Circle
            // 
            draw_Circle.Location = new Point(12, 12);
            draw_Circle.Name = "draw_Circle";
            draw_Circle.Size = new Size(200, 23);
            draw_Circle.TabIndex = 1;
            draw_Circle.Text = "Нарисовать круг";
            draw_Circle.UseVisualStyleBackColor = true;
            draw_Circle.Click += draw_Circle_Click;
            // 
            // Drawing
            // 
            Drawing.Location = new Point(12, 415);
            Drawing.Name = "Drawing";
            Drawing.Size = new Size(200, 23);
            Drawing.TabIndex = 0;
            Drawing.Text = "Нарисовать";
            Drawing.UseVisualStyleBackColor = true;
            Drawing.Click += Drawing_Click;
            // 
            // draw_Rectangle
            // 
            draw_Rectangle.Location = new Point(12, 102);
            draw_Rectangle.Name = "draw_Rectangle";
            draw_Rectangle.Size = new Size(200, 23);
            draw_Rectangle.TabIndex = 2;
            draw_Rectangle.Text = "Нарисовать прямоугольник";
            draw_Rectangle.UseVisualStyleBackColor = true;
            draw_Rectangle.Click += draw_Rectangle_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_length);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_width);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(11, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 93);
            panel2.TabIndex = 3;
            // 
            // textBox_length
            // 
            textBox_length.Location = new Point(3, 55);
            textBox_length.Name = "textBox_length";
            textBox_length.Size = new Size(194, 23);
            textBox_length.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 38);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 1;
            label3.Text = "Введите длину";
            // 
            // textBox_width
            // 
            textBox_width.Location = new Point(3, 13);
            textBox_width.Name = "textBox_width";
            textBox_width.Size = new Size(194, 23);
            textBox_width.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, -3);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Введите ширину";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox_triangle3);
            panel3.Controls.Add(textBox_triangle1);
            panel3.Controls.Add(textBox_triangle2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 139);
            panel3.TabIndex = 4;
            // 
            // textBox_triangle3
            // 
            textBox_triangle3.Location = new Point(0, 114);
            textBox_triangle3.Name = "textBox_triangle3";
            textBox_triangle3.Size = new Size(194, 23);
            textBox_triangle3.TabIndex = 10;
            // 
            // textBox_triangle1
            // 
            textBox_triangle1.Location = new Point(2, 28);
            textBox_triangle1.Name = "textBox_triangle1";
            textBox_triangle1.Size = new Size(194, 23);
            textBox_triangle1.TabIndex = 8;
            // 
            // textBox_triangle2
            // 
            textBox_triangle2.Location = new Point(2, 68);
            textBox_triangle2.Name = "textBox_triangle2";
            textBox_triangle2.Size = new Size(194, 23);
            textBox_triangle2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 96);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 2;
            label6.Text = "Введите сторону 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 50);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 1;
            label5.Text = "Введите сторону 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 0;
            label4.Text = "Введите сторону 1";
            // 
            // draw_Triangle
            // 
            draw_Triangle.Location = new Point(12, 228);
            draw_Triangle.Name = "draw_Triangle";
            draw_Triangle.Size = new Size(200, 23);
            draw_Triangle.TabIndex = 5;
            draw_Triangle.Text = "Нарисовать треугольник";
            draw_Triangle.UseVisualStyleBackColor = true;
            draw_Triangle.Click += draw_Triangle_Click;
            // 
            // panel_drawing
            // 
            panel_drawing.Location = new Point(218, 102);
            panel_drawing.Name = "panel_drawing";
            panel_drawing.Size = new Size(570, 336);
            panel_drawing.TabIndex = 6;
            // 
            // textBox_info
            // 
            textBox_info.Location = new Point(218, 31);
            textBox_info.Multiline = true;
            textBox_info.Name = "textBox_info";
            textBox_info.Size = new Size(570, 50);
            textBox_info.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 9);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 8;
            label7.Text = "Информация";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(490, 84);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 9;
            label8.Text = "Фигура";
            // 
            // Drawable_4_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox_info);
            Controls.Add(panel_drawing);
            Controls.Add(draw_Triangle);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(draw_Rectangle);
            Controls.Add(Drawing);
            Controls.Add(draw_Circle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Drawable_4_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawable(4)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button draw_Circle;
        private Button Drawing;
        private Label label1;
        private Button draw_Rectangle;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button draw_Triangle;
        private TextBox textBox_radius;
        private TextBox textBox_length;
        private TextBox textBox_width;
        private TextBox textBox_triangle3;
        private TextBox textBox_triangle1;
        private TextBox textBox_triangle2;
        private Panel panel_drawing;
        private TextBox textBox_info;
        private Label label7;
        private Label label8;
    }
}