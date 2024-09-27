namespace Mod_2
{
    partial class TemperatureSensor_5_
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
            button_Check = new Button();
            textBox_Check = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_info = new TextBox();
            SuspendLayout();
            // 
            // button_Check
            // 
            button_Check.Location = new Point(12, 56);
            button_Check.Name = "button_Check";
            button_Check.Size = new Size(239, 23);
            button_Check.TabIndex = 0;
            button_Check.Text = "Узнать";
            button_Check.UseVisualStyleBackColor = true;
            button_Check.Click += button_Check_Click;
            // 
            // textBox_Check
            // 
            textBox_Check.Location = new Point(12, 27);
            textBox_Check.Name = "textBox_Check";
            textBox_Check.Size = new Size(239, 23);
            textBox_Check.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите температуру";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 103);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Инфо:";
            // 
            // textBox_info
            // 
            textBox_info.Enabled = false;
            textBox_info.Location = new Point(12, 121);
            textBox_info.Name = "textBox_info";
            textBox_info.Size = new Size(239, 23);
            textBox_info.TabIndex = 4;
            // 
            // TemperatureSensor_5_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 167);
            Controls.Add(textBox_info);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Check);
            Controls.Add(button_Check);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TemperatureSensor_5_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TemperatureSensor(5)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Check;
        private TextBox textBox_Check;
        private Label label1;
        private Label label2;
        private TextBox textBox_info;
    }
}