﻿namespace Mod_2
{
    partial class Compasition_3_
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
            tableCompasition = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tableCompasition).BeginInit();
            SuspendLayout();
            // 
            // tableCompasition
            //  
            tableCompasition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableCompasition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCompasition.Location = new Point(12, 12);
            tableCompasition.Name = "tableCompasition";
            tableCompasition.Size = new Size(776, 426);
            tableCompasition.TabIndex = 0;
            // 
            // Compasition_3_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableCompasition);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Compasition_3_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compasition(3)";
            ((System.ComponentModel.ISupportInitialize)tableCompasition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableCompasition;
    }
}