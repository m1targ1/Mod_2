namespace Mod_2
{
    public partial class Library_3_3_ : Form
    {
        public int bookCounter = 1;  // Переменная для счётчика
        private Library library = new Library(); // Объект библиотеки
        public Library_3_3_()
        {
            InitializeComponent();
            // Настройка столбцов для таблицы
            tableLibrary.ColumnCount = 5; // Количество столбцов в таблице
            tableLibrary.Columns[0].Name = "№"; tableLibrary.Columns[1].Name = "Название книги"; tableLibrary.Columns[2].Name = "Год выпуска";
            tableLibrary.Columns[3].Name = "Автор"; tableLibrary.Columns[4].Name = "Год рождения";
        }
        private void button_Add_Author_Click(object sender, EventArgs e)
        {
            // Включение и отключение элементов управления
            textBox_SurName.Enabled = true; textBox_Name.Enabled = true; textBox_BirthYear.Enabled = true; button_authors.Enabled = true;
            textBox_Title.Enabled = false; textBox_Year.Enabled = false; comboBox_Choise_author.Enabled = false; button_books.Enabled = false;
            textBox_Del_Title.Enabled = false; button_Del.Enabled = false; textBox_search.Enabled = false; button_search.Enabled = false;
            comboBox_criteria_search.Enabled = false;
        }
        private void button_Add_Book_Click(object sender, EventArgs e)
        {
            // Включение и отключение элементов управления
            textBox_SurName.Enabled = false; textBox_Name.Enabled = false; textBox_BirthYear.Enabled = false; button_authors.Enabled = false;
            textBox_Title.Enabled = true; textBox_Year.Enabled = true; comboBox_Choise_author.Enabled = true; button_books.Enabled = true;
            textBox_Del_Title.Enabled = false; button_Del.Enabled = false; textBox_search.Enabled = false; button_search.Enabled = false;
            comboBox_criteria_search.Enabled = false;
        }
        private void button_Del_Book_Click(object sender, EventArgs e)
        {
            // Включение и отключение элементов управления
            textBox_SurName.Enabled = false; textBox_Name.Enabled = false; textBox_BirthYear.Enabled = false; button_authors.Enabled = false;
            textBox_Title.Enabled = false; textBox_Year.Enabled = false; comboBox_Choise_author.Enabled = false; button_books.Enabled = false; 
            textBox_Del_Title.Enabled = true; button_Del.Enabled = true; textBox_search.Enabled = false; button_search.Enabled = false;
            comboBox_criteria_search.Enabled = false;
        }
        private void button_search_Book_Click(object sender, EventArgs e)
        {
            // Проверка на наличие элементов для выбора
            if (comboBox_criteria_search.Items.Count == 0)
            {
                // Добавление элементов выбора
                comboBox_criteria_search.Items.Add("Год"); comboBox_criteria_search.Items.Add("Автор");
            }
            // Включение и отключение элементов управления
            textBox_SurName.Enabled = false; textBox_Name.Enabled = false; textBox_BirthYear.Enabled = false; button_authors.Enabled = false;
            textBox_Title.Enabled = false; textBox_Year.Enabled = false; comboBox_Choise_author.Enabled = false; button_books.Enabled = false;
            textBox_Del_Title.Enabled = false; button_Del.Enabled = false; textBox_search.Enabled = true; button_search.Enabled = true;
            comboBox_criteria_search.Enabled = true;
        }
        private void button_authors_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных из текстовых полей
                string surname = textBox_SurName.Text; string name = textBox_Name.Text; int birthYear = int.Parse(textBox_BirthYear.Text);
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Фамилия и имя не могут быть пустыми.");
                    return;
                }
                Authors newAuthor = new Authors(surname, name, birthYear); // Создание нового объекта типа Authors
                library.AddAuthor(newAuthor);
                comboBox_Choise_author.Items.Add(newAuthor); // Добавляем объект
                // Очистка и отключение элементов управления
                textBox_SurName.Clear(); textBox_Name.Clear(); textBox_BirthYear.Clear(); textBox_SurName.Enabled = false;
                textBox_Name.Enabled = false; textBox_BirthYear.Enabled = false; button_authors.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод года рождения. Пожалуйста, введите число.");
            }
        }
        private void button_books_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных из текстовых полей
                string title = textBox_Title.Text; int year = int.Parse(textBox_Year.Text);
                Authors selectedAuthor = comboBox_Choise_author.SelectedItem as Authors; // Выбор автора
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(title) || selectedAuthor == null)
                {
                    MessageBox.Show("Пожалуйста, укажите название книги и выберите автора.");
                    return;
                }
                Books newBook = new Books(title, year, selectedAuthor); // Создание нового объекта типа Books
                library.AddBook(newBook);
                tableLibrary.Rows.Add(bookCounter++, title, year, selectedAuthor.Name, selectedAuthor.BirthYear); // Добавление в таблицу
                // Очистка полей ввода
                textBox_Title.Clear(); textBox_Year.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод года. Пожалуйста, введите число.");
            }
        }
        private void button_Del_Click(object sender, EventArgs e)
        {
                // Получкние введённых данных
                string title = textBox_Del_Title.Text;
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Пожалуйста, укажите название книги для удаления.");
                    return;
                }

                bool removed = library.RemoveBook(title);
                if (removed)
                {
                    // Обновление таблицы, если книга была удалена
                    foreach (DataGridViewRow row in tableLibrary.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == title)
                        {
                            tableLibrary.Rows.Remove(row);
                            bookCounter--; // Счётчик уменьшается
                            break;
                        }
                    }
                    MessageBox.Show($"Книга '{title}' удалена.");
                }
                else
                {
                    MessageBox.Show("Книга не найдена.");
                }

        }
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на выбранный критерий
                if (comboBox_criteria_search.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите критерий поиска.");
                    return;
                }
                string criteria = comboBox_criteria_search.SelectedItem.ToString();
                string searchValue = textBox_search.Text;
                List<Books> foundBooks = new List<Books>();
                // Поиск в зависимости от выбранного критерия
                if (criteria == "Год")
                {
                    if (int.TryParse(searchValue, out int year))
                    {
                        foundBooks = library.SearchBooks("year", year.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, введите корректный год.");
                        return;
                    }
                }
                else if (criteria == "Автор")
                {
                    if (!string.IsNullOrWhiteSpace(searchValue))
                    {
                        foundBooks = library.SearchBooks("author", searchValue);
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, введите имя или фамилию автора.");
                        return;
                    }
                }
                // Очистка таблицы и добавление найденных книг
                tableLibrary.Rows.Clear();
                bookCounter = 1;
                foreach (var book in foundBooks)
                {
                    tableLibrary.Rows.Add(bookCounter++, book.Title, book.Year, book.Author.Name, book.Author.BirthYear);
                }
                if (foundBooks.Count == 0)
                {
                    MessageBox.Show("Книги не найдены.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске книг: " + ex.Message);
            }
        }
        // Сброс поиска
        private void button_reset_Click(object sender, EventArgs e)
        {
            tableLibrary.Rows.Clear();
            List<Books> allBooks = library.GetAllBooks();
            bookCounter = 1;

            foreach (var book in allBooks)
            {
                tableLibrary.Rows.Add(bookCounter++, book.Title, book.Year, book.Author.Name, book.Author.BirthYear);
            }
        }
    }
    // Класс автор
    public class Authors
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Authors(string surname, string name, int birthYear)
        {
            Surname = surname;
            Name = name;
            BirthYear = birthYear;
        }
        public override string ToString()
        {
            return $"{Surname} {Name}"; // Отображение фамилии и имени
        }
    }
    // Класс книг
    public class Books
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Authors Author { get; set; }

        public Books(string title, int year, Authors author)
        {
            Title = title;
            Year = year;
            Author = author;
        }
    }
    // Класс библиотеки
    public class Library
    {
        private List<Books> booksList = new List<Books>();
        private List<Authors> authorsList = new List<Authors>();
        // Добавление автора
        public void AddAuthor(Authors author)
        {
            authorsList.Add(author);
        }

        // Добавление книги
        public void AddBook(Books book)
        {
            booksList.Add(book);
        }
        // Удаление книги
        public bool RemoveBook(string title)
        {
            var book = booksList.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                booksList.Remove(book);
                return true;
            }
            return false;
        }
        // Поиск книг
        public List<Books> SearchBooks(string criteria, string value)
        {
            List<Books> result = new List<Books>();
            if (criteria.ToLower() == "year")
            {
                if (int.TryParse(value, out int year))
                {
                    result = booksList.FindAll(b => b.Year == year);
                }
            }
            else if (criteria.ToLower() == "author")
            {
                result = booksList.FindAll(b => b.Author.Name.Equals(value, StringComparison.OrdinalIgnoreCase) ||
                                                  b.Author.Surname.Equals(value, StringComparison.OrdinalIgnoreCase));
            }
            return result;
        }
        // Возвращает все книги
        public List<Books> GetAllBooks()
        {
            return booksList;
        }
    }
}
