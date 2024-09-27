namespace Mod_2
{
    partial class Employee_6_
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
            button_Add = new Button();
            textBox_surname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_name = new TextBox();
            label3 = new Label();
            textBox_patronymic = new TextBox();
            label4 = new Label();
            textBox_post = new TextBox();
            label5 = new Label();
            textBox_salary = new TextBox();
            tableEmployee = new DataGridView();
            button_Delete = new Button();
            textBox_delete = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableEmployee).BeginInit();
            SuspendLayout();
            // 
            // button_Add
            // 
            button_Add.Location = new Point(12, 56);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(740, 23);
            button_Add.TabIndex = 0;
            button_Add.Text = "Добавить";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(12, 27);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(154, 23);
            textBox_surname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 9);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Имя";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(172, 27);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(154, 23);
            textBox_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 9);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Отчество";
            // 
            // textBox_patronymic
            // 
            textBox_patronymic.Location = new Point(332, 27);
            textBox_patronymic.Name = "textBox_patronymic";
            textBox_patronymic.Size = new Size(154, 23);
            textBox_patronymic.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 9);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 8;
            label4.Text = "Должность";
            // 
            // textBox_post
            // 
            textBox_post.Location = new Point(492, 27);
            textBox_post.Name = "textBox_post";
            textBox_post.Size = new Size(154, 23);
            textBox_post.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(652, 9);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Зарплата";
            // 
            // textBox_salary
            // 
            textBox_salary.Location = new Point(652, 27);
            textBox_salary.Name = "textBox_salary";
            textBox_salary.Size = new Size(100, 23);
            textBox_salary.TabIndex = 9;
            // 
            // tableEmployee
            // 
            tableEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableEmployee.Enabled = false;
            tableEmployee.Location = new Point(12, 85);
            tableEmployee.Name = "tableEmployee";
            tableEmployee.Size = new Size(911, 254);
            tableEmployee.TabIndex = 11;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(783, 56);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(140, 23);
            button_Delete.TabIndex = 12;
            button_Delete.Text = "Удалить";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // textBox_delete
            // 
            textBox_delete.Location = new Point(783, 27);
            textBox_delete.Name = "textBox_delete";
            textBox_delete.Size = new Size(140, 23);
            textBox_delete.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 9);
            label6.Name = "label6";
            label6.Size = new Size(165, 15);
            label6.TabIndex = 14;
            label6.Text = "Введите номер для удаления";
            // 
            // Employee_6_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 352);
            Controls.Add(label6);
            Controls.Add(textBox_delete);
            Controls.Add(button_Delete);
            Controls.Add(tableEmployee);
            Controls.Add(label5);
            Controls.Add(textBox_salary);
            Controls.Add(label4);
            Controls.Add(textBox_post);
            Controls.Add(label3);
            Controls.Add(textBox_patronymic);
            Controls.Add(label2);
            Controls.Add(textBox_name);
            Controls.Add(label1);
            Controls.Add(textBox_surname);
            Controls.Add(button_Add);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Employee_6_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee(3_1)";
            ((System.ComponentModel.ISupportInitialize)tableEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Add;
        private TextBox textBox_surname;
        private Label label1;
        private Label label2;
        private TextBox textBox_name;
        private Label label3;
        private TextBox textBox_patronymic;
        private Label label4;
        private TextBox textBox_post;
        private Label label5;
        private TextBox textBox_salary;
        private DataGridView tableEmployee;
        private Button button_Delete;
        private TextBox textBox_delete;
        private Label label6;
    }
}