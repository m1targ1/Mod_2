namespace Mod_2
{
    partial class ClassPerson_1_
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
            Add_to_list = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox_Adress = new TextBox();
            textBox_Age = new TextBox();
            textBox_FIO = new TextBox();
            label1 = new Label();
            Add_Person = new Button();
            Check_List_person = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Add_to_list);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Adress);
            panel1.Controls.Add(textBox_Age);
            panel1.Controls.Add(textBox_FIO);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 189);
            panel1.TabIndex = 0;
            // 
            // Add_to_list
            // 
            Add_to_list.Enabled = false;
            Add_to_list.Location = new Point(40, 147);
            Add_to_list.Name = "Add_to_list";
            Add_to_list.Size = new Size(233, 39);
            Add_to_list.TabIndex = 6;
            Add_to_list.Text = "Добавить";
            Add_to_list.UseVisualStyleBackColor = true;
            Add_to_list.Click += Add_to_list_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Введите адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Введите возраст";
            // 
            // textBox_Adress
            // 
            textBox_Adress.Enabled = false;
            textBox_Adress.Location = new Point(10, 118);
            textBox_Adress.Name = "textBox_Adress";
            textBox_Adress.Size = new Size(302, 23);
            textBox_Adress.TabIndex = 3;
            // 
            // textBox_Age
            // 
            textBox_Age.Enabled = false;
            textBox_Age.Location = new Point(10, 74);
            textBox_Age.Name = "textBox_Age";
            textBox_Age.Size = new Size(302, 23);
            textBox_Age.TabIndex = 2;
            // 
            // textBox_FIO
            // 
            textBox_FIO.Enabled = false;
            textBox_FIO.Location = new Point(10, 30);
            textBox_FIO.Name = "textBox_FIO";
            textBox_FIO.Size = new Size(302, 23);
            textBox_FIO.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите ФИО";
            // 
            // Add_Person
            // 
            Add_Person.Location = new Point(20, 12);
            Add_Person.Name = "Add_Person";
            Add_Person.Size = new Size(330, 23);
            Add_Person.TabIndex = 2;
            Add_Person.Text = "Добавить человека";
            Add_Person.UseVisualStyleBackColor = true;
            Add_Person.Click += Add_Person_Click;
            // 
            // Check_List_person
            // 
            Check_List_person.Location = new Point(356, 12);
            Check_List_person.Name = "Check_List_person";
            Check_List_person.Size = new Size(330, 23);
            Check_List_person.TabIndex = 3;
            Check_List_person.Text = "Просмотреть список людей";
            Check_List_person.UseVisualStyleBackColor = true;
            Check_List_person.Click += Check_List_person_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(356, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(330, 383);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // ClassPerson_1_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 436);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Check_List_person);
            Controls.Add(Add_Person);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClassPerson_1_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassPerson(1)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Add_Person;
        private Button Add_to_list;
        private Label label3;
        private Label label2;
        private TextBox textBox_Adress;
        private TextBox textBox_Age;
        private TextBox textBox_FIO;
        private Label label1;
        private Button Check_List_person;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}