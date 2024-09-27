namespace Mod_2
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button_ClassPerson = new Button();
            Button_ClassShape = new Button();
            Button_Composition = new Button();
            Button_Drawable = new Button();
            Button_Temperature = new Button();
            Button_Employee = new Button();
            Button_TwoVar = new Button();
            Button_Library = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Button_ClassPerson
            // 
            Button_ClassPerson.Location = new Point(12, 27);
            Button_ClassPerson.Name = "Button_ClassPerson";
            Button_ClassPerson.Size = new Size(221, 23);
            Button_ClassPerson.TabIndex = 0;
            Button_ClassPerson.Text = "Класс Person (1)";
            Button_ClassPerson.UseVisualStyleBackColor = true;
            Button_ClassPerson.Click += Button_ClassPerson_Click;
            // 
            // Button_ClassShape
            // 
            Button_ClassShape.Location = new Point(12, 56);
            Button_ClassShape.Name = "Button_ClassShape";
            Button_ClassShape.Size = new Size(221, 23);
            Button_ClassShape.TabIndex = 1;
            Button_ClassShape.Text = "Класс Shape (2)";
            Button_ClassShape.UseVisualStyleBackColor = true;
            Button_ClassShape.Click += Button_ClassShape_Click;
            // 
            // Button_Composition
            // 
            Button_Composition.Location = new Point(12, 85);
            Button_Composition.Name = "Button_Composition";
            Button_Composition.Size = new Size(221, 23);
            Button_Composition.TabIndex = 2;
            Button_Composition.Text = "Композиция (3)";
            Button_Composition.UseVisualStyleBackColor = true;
            Button_Composition.Click += Button_Composition_Click;
            // 
            // Button_Drawable
            // 
            Button_Drawable.Location = new Point(12, 114);
            Button_Drawable.Name = "Button_Drawable";
            Button_Drawable.Size = new Size(221, 23);
            Button_Drawable.TabIndex = 3;
            Button_Drawable.Text = "Интерфейс Drawable (4)";
            Button_Drawable.UseVisualStyleBackColor = true;
            Button_Drawable.Click += Button_Drawable_Click;
            // 
            // Button_Temperature
            // 
            Button_Temperature.Location = new Point(12, 143);
            Button_Temperature.Name = "Button_Temperature";
            Button_Temperature.Size = new Size(221, 24);
            Button_Temperature.TabIndex = 4;
            Button_Temperature.Text = "Класс TemperatureSensor (5)";
            Button_Temperature.UseVisualStyleBackColor = true;
            Button_Temperature.Click += Button_Temperature_Click;
            // 
            // Button_Employee
            // 
            Button_Employee.Location = new Point(12, 173);
            Button_Employee.Name = "Button_Employee";
            Button_Employee.Size = new Size(221, 23);
            Button_Employee.TabIndex = 5;
            Button_Employee.Text = "Класс Сотрудник (В3_1)";
            Button_Employee.UseVisualStyleBackColor = true;
            Button_Employee.Click += Button_Employee_Click;
            // 
            // Button_TwoVar
            // 
            Button_TwoVar.Location = new Point(12, 202);
            Button_TwoVar.Name = "Button_TwoVar";
            Button_TwoVar.Size = new Size(221, 23);
            Button_TwoVar.TabIndex = 6;
            Button_TwoVar.Text = " Класс с двумя переменными (В3_2)";
            Button_TwoVar.UseVisualStyleBackColor = true;
            Button_TwoVar.Click += Button_TwoVar_Click;
            // 
            // Button_Library
            // 
            Button_Library.Location = new Point(12, 231);
            Button_Library.Name = "Button_Library";
            Button_Library.Size = new Size(221, 23);
            Button_Library.TabIndex = 7;
            Button_Library.Text = "Класс Библиотека (В3_3)";
            Button_Library.UseVisualStyleBackColor = true;
            Button_Library.Click += Button_Library_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 8;
            label1.Text = "Модуль 2";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 264);
            Controls.Add(label1);
            Controls.Add(Button_Library);
            Controls.Add(Button_TwoVar);
            Controls.Add(Button_Employee);
            Controls.Add(Button_Temperature);
            Controls.Add(Button_Drawable);
            Controls.Add(Button_Composition);
            Controls.Add(Button_ClassShape);
            Controls.Add(Button_ClassPerson);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_ClassPerson;
        private Button Button_ClassShape;
        private Button Button_Composition;
        private Button Button_Drawable;
        private Button Button_Temperature;
        private Button Button_Employee;
        private Button Button_TwoVar;
        private Button Button_Library;
        private Label label1;
    }
}
