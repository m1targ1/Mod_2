namespace Mod_2
{
    partial class Library_3_3_
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
            button_Add_Author = new Button();
            button_Add_Book = new Button();
            tableLibrary = new DataGridView();
            textBox_SurName = new TextBox();
            textBox_Name = new TextBox();
            textBox_BirthYear = new TextBox();
            textBox_Title = new TextBox();
            textBox_Year = new TextBox();
            button_Del_Book = new Button();
            textBox_Del_Title = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button_search_Book = new Button();
            textBox_search = new TextBox();
            button_reset = new Button();
            button_Del = new Button();
            button_search = new Button();
            comboBox_Choise_author = new ComboBox();
            comboBox_criteria_search = new ComboBox();
            button_authors = new Button();
            button_books = new Button();
            ((System.ComponentModel.ISupportInitialize)tableLibrary).BeginInit();
            SuspendLayout();
            // 
            // button_Add_Author
            // 
            button_Add_Author.Location = new Point(12, 12);
            button_Add_Author.Name = "button_Add_Author";
            button_Add_Author.Size = new Size(177, 23);
            button_Add_Author.TabIndex = 0;
            button_Add_Author.Text = "Добавить автора";
            button_Add_Author.UseVisualStyleBackColor = true;
            button_Add_Author.Click += button_Add_Author_Click;
            //  
            // button_Add_Book
            // 
            button_Add_Book.Location = new Point(205, 12);
            button_Add_Book.Name = "button_Add_Book";
            button_Add_Book.Size = new Size(177, 23);
            button_Add_Book.TabIndex = 1;
            button_Add_Book.Text = "Добавить книгу";
            button_Add_Book.UseVisualStyleBackColor = true;
            button_Add_Book.Click += button_Add_Book_Click;
            // 
            // tableLibrary
            // 
            tableLibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLibrary.Location = new Point(12, 202);
            tableLibrary.Name = "tableLibrary";
            tableLibrary.Size = new Size(775, 267);
            tableLibrary.TabIndex = 2;
            // 
            // textBox_SurName
            // 
            textBox_SurName.Enabled = false;
            textBox_SurName.Location = new Point(12, 56);
            textBox_SurName.Name = "textBox_SurName";
            textBox_SurName.Size = new Size(177, 23);
            textBox_SurName.TabIndex = 3;
            // 
            // textBox_Name
            // 
            textBox_Name.Enabled = false;
            textBox_Name.Location = new Point(12, 100);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(177, 23);
            textBox_Name.TabIndex = 4;
            // 
            // textBox_BirthYear
            // 
            textBox_BirthYear.Enabled = false;
            textBox_BirthYear.Location = new Point(12, 144);
            textBox_BirthYear.Name = "textBox_BirthYear";
            textBox_BirthYear.Size = new Size(177, 23);
            textBox_BirthYear.TabIndex = 5;
            // 
            // textBox_Title
            // 
            textBox_Title.Enabled = false;
            textBox_Title.Location = new Point(205, 56);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(177, 23);
            textBox_Title.TabIndex = 6;
            // 
            // textBox_Year
            // 
            textBox_Year.Enabled = false;
            textBox_Year.Location = new Point(205, 100);
            textBox_Year.Name = "textBox_Year";
            textBox_Year.Size = new Size(177, 23);
            textBox_Year.TabIndex = 7;
            // 
            // button_Del_Book
            // 
            button_Del_Book.Location = new Point(397, 12);
            button_Del_Book.Name = "button_Del_Book";
            button_Del_Book.Size = new Size(177, 23);
            button_Del_Book.TabIndex = 8;
            button_Del_Book.Text = "Удалить книгу";
            button_Del_Book.UseVisualStyleBackColor = true;
            button_Del_Book.Click += button_Del_Book_Click;
            // 
            // textBox_Del_Title
            // 
            textBox_Del_Title.Enabled = false;
            textBox_Del_Title.Location = new Point(397, 56);
            textBox_Del_Title.Name = "textBox_Del_Title";
            textBox_Del_Title.Size = new Size(177, 23);
            textBox_Del_Title.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 10;
            label1.Text = "Введите фамилию";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 11;
            label2.Text = "Введите имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 12;
            label3.Text = "Введите год рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 38);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 13;
            label4.Text = "Введите название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 82);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 14;
            label5.Text = "Введите год выпуска";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 126);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 15;
            label6.Text = "Выберите автора";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 38);
            label7.Name = "label7";
            label7.Size = new Size(179, 15);
            label7.TabIndex = 16;
            label7.Text = "Введите название для удаления";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(610, 38);
            label8.Name = "label8";
            label8.Size = new Size(165, 15);
            label8.TabIndex = 17;
            label8.Text = "Выберите критериий поиска";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(610, 82);
            label9.Name = "label9";
            label9.Size = new Size(182, 15);
            label9.TabIndex = 18;
            label9.Text = "Введите автора или год издания";
            // 
            // button_search_Book
            // 
            button_search_Book.Location = new Point(610, 12);
            button_search_Book.Name = "button_search_Book";
            button_search_Book.Size = new Size(177, 23);
            button_search_Book.TabIndex = 19;
            button_search_Book.Text = "Найти книгу";
            button_search_Book.UseVisualStyleBackColor = true;
            button_search_Book.Click += button_search_Book_Click;
            // 
            // textBox_search
            // 
            textBox_search.Enabled = false;
            textBox_search.Location = new Point(610, 100);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(177, 23);
            textBox_search.TabIndex = 20;
            // 
            // button_reset
            // 
            button_reset.Location = new Point(610, 158);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(177, 23);
            button_reset.TabIndex = 21;
            button_reset.Text = "Сброс поиска";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // button_Del
            // 
            button_Del.Enabled = false;
            button_Del.Location = new Point(397, 85);
            button_Del.Name = "button_Del";
            button_Del.Size = new Size(177, 23);
            button_Del.TabIndex = 22;
            button_Del.Text = "УДАЛИТЬ";
            button_Del.UseVisualStyleBackColor = true;
            button_Del.Click += button_Del_Click;
            // 
            // button_search
            // 
            button_search.Enabled = false;
            button_search.Location = new Point(610, 129);
            button_search.Name = "button_search";
            button_search.Size = new Size(177, 23);
            button_search.TabIndex = 23;
            button_search.Text = "ПОИСК";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // comboBox_Choise_author
            // 
            comboBox_Choise_author.Enabled = false;
            comboBox_Choise_author.FormattingEnabled = true;
            comboBox_Choise_author.Location = new Point(205, 144);
            comboBox_Choise_author.Name = "comboBox_Choise_author";
            comboBox_Choise_author.Size = new Size(177, 23);
            comboBox_Choise_author.TabIndex = 24;
            // 
            // comboBox_criteria_search
            // 
            comboBox_criteria_search.Enabled = false;
            comboBox_criteria_search.FormattingEnabled = true;
            comboBox_criteria_search.Location = new Point(610, 56);
            comboBox_criteria_search.Name = "comboBox_criteria_search";
            comboBox_criteria_search.Size = new Size(177, 23);
            comboBox_criteria_search.TabIndex = 25;
            // 
            // button_authors
            // 
            button_authors.Enabled = false;
            button_authors.Location = new Point(12, 173);
            button_authors.Name = "button_authors";
            button_authors.Size = new Size(177, 23);
            button_authors.TabIndex = 26;
            button_authors.Text = "ДОБАВИТЬ";
            button_authors.UseVisualStyleBackColor = true;
            button_authors.Click += button_authors_Click;
            // 
            // button_books
            // 
            button_books.Enabled = false;
            button_books.Location = new Point(205, 173);
            button_books.Name = "button_books";
            button_books.Size = new Size(177, 23);
            button_books.TabIndex = 27;
            button_books.Text = "ДОБАВИТЬ";
            button_books.UseVisualStyleBackColor = true;
            button_books.Click += button_books_Click;
            // 
            // Library_3_3_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(button_books);
            Controls.Add(button_authors);
            Controls.Add(comboBox_criteria_search);
            Controls.Add(comboBox_Choise_author);
            Controls.Add(button_search);
            Controls.Add(button_Del);
            Controls.Add(button_reset);
            Controls.Add(textBox_search);
            Controls.Add(button_search_Book);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Del_Title);
            Controls.Add(button_Del_Book);
            Controls.Add(textBox_Year);
            Controls.Add(textBox_Title);
            Controls.Add(textBox_BirthYear);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_SurName);
            Controls.Add(tableLibrary);
            Controls.Add(button_Add_Book);
            Controls.Add(button_Add_Author);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Library_3_3_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library(3_3)";
            ((System.ComponentModel.ISupportInitialize)tableLibrary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Add_Author;
        private Button button_Add_Book;
        private DataGridView tableLibrary;
        private TextBox textBox_SurName;
        private TextBox textBox_Name;
        private TextBox textBox_BirthYear;
        private TextBox textBox_Title;
        private TextBox textBox_Year;
        private Button button_Del_Book;
        private TextBox textBox_Del_Title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button_search_Book;
        private TextBox textBox_search;
        private Button button_reset;
        private Button button_Del;
        private Button button_search;
        private ComboBox comboBox_Choise_author;
        private ComboBox comboBox_criteria_search;
        private Button button_authors;
        private Button button_books;
    }
}