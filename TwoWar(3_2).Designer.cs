namespace Mod_2
{
    partial class TwoWar_3_2_
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
            button_AddDefault = new Button();
            button_Del = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox_number = new TextBox();
            textBox_text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_AddObj = new Button();
            SuspendLayout();
            // 
            // button_Add
            // 
            button_Add.Location = new Point(12, 12);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(208, 23);
            button_Add.TabIndex = 0;
            button_Add.Text = "Добавить объект";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_AddDefault
            // 
            button_AddDefault.Location = new Point(12, 200);
            button_AddDefault.Name = "button_AddDefault";
            button_AddDefault.Size = new Size(208, 23);
            button_AddDefault.TabIndex = 1;
            button_AddDefault.Text = "Добавить объект по умолчанию";
            button_AddDefault.UseVisualStyleBackColor = true;
            button_AddDefault.Click += button_AddDefault_Click;
            // 
            // button_Del
            // 
            button_Del.Location = new Point(12, 271);
            button_Del.Name = "button_Del";
            button_Del.Size = new Size(208, 23);
            button_Del.TabIndex = 2;
            button_Del.Text = "Удалить все объекты";
            button_Del.UseVisualStyleBackColor = true;
            button_Del.Click += button_Del_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(226, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(223, 282);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // textBox_number
            // 
            textBox_number.Location = new Point(12, 56);
            textBox_number.Name = "textBox_number";
            textBox_number.Size = new Size(208, 23);
            textBox_number.TabIndex = 4;
            // 
            // textBox_text
            // 
            textBox_text.Location = new Point(12, 100);
            textBox_text.Name = "textBox_text";
            textBox_text.Size = new Size(208, 23);
            textBox_text.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 6;
            label1.Text = "Введите номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "Введите текст";
            // 
            // button_AddObj
            // 
            button_AddObj.Location = new Point(12, 129);
            button_AddObj.Name = "button_AddObj";
            button_AddObj.Size = new Size(208, 23);
            button_AddObj.TabIndex = 8;
            button_AddObj.Text = "Добавить";
            button_AddObj.UseVisualStyleBackColor = true;
            button_AddObj.Click += button_AddObj_Click;
            // 
            // TwoWar_3_2_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 307);
            Controls.Add(button_AddObj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_text);
            Controls.Add(textBox_number);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button_Del);
            Controls.Add(button_AddDefault);
            Controls.Add(button_Add);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TwoWar_3_2_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TwoWar(3_2)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Add;
        private Button button_AddDefault;
        private Button button_Del;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox_number;
        private TextBox textBox_text;
        private Label label1;
        private Label label2;
        private Button button_AddObj;
    }
}