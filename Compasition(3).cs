using static Mod_2.Compasition_3_.Author;

namespace Mod_2
{
    public partial class Compasition_3_ : Form
    {
        // Метод для получения списка книг
        public List<Book> GetBooks()
        {
            //  Новые объекты (авторы) с именем и годом рождения
            Author author1 = new Author("Лев Толстой", 1828);
            Author author2 = new Author("Фёдор Достоевский", 1821);
            Author author3 = new Author("Михаил Булгаков", 1891);

            // Создание список книг, используя объекты авторов
            List<Book> books = new List<Book>
            {
                new Book("Война и мир", 1869, author1), // Создание книги с названием, годом выпуска и автором
                new Book("Преступление и наказание", 1866, author2), // Еще одна книга
                new Book("Мастер и Маргарита", 1967, author3) // Еще одна книга
            };

            // Возвращает список книг
            return books;
        }

        public Compasition_3_()
        {
            InitializeComponent();

            // Настраиваем столбцы для компонента DataGridView (таблица)
            tableCompasition.ColumnCount = 4; // Количество столбцов в таблице
            tableCompasition.Columns[0].Name = "Название книги";
            tableCompasition.Columns[1].Name = "Год выпуска";
            tableCompasition.Columns[2].Name = "Автор";
            tableCompasition.Columns[3].Name = "Год рождения";

            // Получение списка книг, вызвав метод GetBooks
            List<Book> books = GetBooks();

            // Заполнение таблицы данными о книгах
            foreach (var book in books)
            {
                // Добавление новой строки с информацией о каждой книге в таблицу
                tableCompasition.Rows.Add(book.Title, book.ReleaseYear, book.Author.Name, book.Author.BirthYear);
            }
        }

        // Класс, представляющий автора
        public class Author
        {
            // Свойства автора: имя и год рождения
            public string Name { get; set; }
            public int BirthYear { get; set; }

            // Конструктор класса Author, принимающий имя и год рождения
            public Author(string name, int birthYear)
            {
                Name = name; // Инициализация имени автора
                BirthYear = birthYear; // Инициализация года рождения автора
            }

            // Класс для представления книги
            public class Book
            {
                // Свойства книги: название, год выпуска, автор
                public string Title { get; set; }
                public int ReleaseYear { get; set; }
                public Author Author { get; set; } // Связь с автором

                // Конструктор класса Book, принимающий название, год выпуска и объект автора
                public Book(string title, int releaseYear, Author author)
                {
                    Title = title; // Инициализация названия книги
                    ReleaseYear = releaseYear; // Инициализация года выпуска
                    Author = author; // Инициализация автора книги
                }
            }
        }
    }
}
