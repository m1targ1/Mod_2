namespace Mod_2
{
    public partial class Employee_6_ : Form
    {
        public int number = 1;  // Переменная для счётчика
        List<Employee> employeeList = new List<Employee>();   // Создание нового списка для работников

        public List<Employee> GetEmployee()
        {
            return employeeList; // Возвращает список сотрудников
        }

        public Employee_6_()
        {
            InitializeComponent();
            tableEmployee.ColumnCount = 7; // Количество столбцов в таблице
            tableEmployee.Columns[0].Name = "№";
            tableEmployee.Columns[1].Name = "Фамилия";
            tableEmployee.Columns[2].Name = "Имя";
            tableEmployee.Columns[3].Name = "Отчество";
            tableEmployee.Columns[4].Name = "Должность";
            tableEmployee.Columns[5].Name = "Зарплата";
            tableEmployee.Columns[6].Name = "Годовой доход";
            textBox_salary.KeyPress += textBox_salary_KeyPress; // Вызов обработчик события для текстового поля ввода зарплаты
        }
        // Обработчик события для валидации ввода в поле зарплаты
        private void textBox_salary_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Разрешение на ввод только цифр, запятой и клавиши Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Отменить ввод символа
                MessageBox.Show("Пожалуйста, введите корректное числовое значение.");
            }
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность всех полей
            if (textBox_surname.Text != "" && textBox_name.Text != "" && textBox_patronymic.Text != "" && textBox_post.Text != "" && textBox_salary.Text != "")
            {
                // Получение данных из текстовых полей
                string surname = textBox_surname.Text;
                string name = textBox_name.Text;
                string patronymic = textBox_patronymic.Text;
                string post = textBox_post.Text;
                string salary = textBox_salary.Text;

                // Создание нового объекта Employee
                Employee newEmployee = new Employee(number, surname, name, patronymic, post, salary, "");
                employeeList.Add(newEmployee);
                // Добавление данных о сотруднике в таблицу
                tableEmployee.Rows.Add(newEmployee.numbers, newEmployee.surname, newEmployee.name, newEmployee.patronymic, newEmployee.post, newEmployee.salary, newEmployee.Financee());
                number++; // Увеличение счётчика сотрудников
                // Очистка полей ввода
                textBox_surname.Text = "";
                textBox_name.Text = "";
                textBox_patronymic.Text = "";
                textBox_post.Text = "";
                textBox_salary.Text = "";
            }
            else
            {
                MessageBox.Show("Введите корректные данные"); // Вывод сообщения об ошибке
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            // Проверка на наличие номера сотрудника в поле удаления
            if (int.TryParse(textBox_delete.Text, out int employeeNumber))
            {
                // Поиск сотрудника по номеру в списке
                Employee? employeeToRemove = employeeList.FirstOrDefault(emp => emp.numbers == employeeNumber);
                // Если есть люди для удаления
                if (employeeToRemove != null)
                {
                    employeeList.Remove(employeeToRemove);
                    RecalculateEmployeeNumbers();  // Обновление нумерации
                    MessageBox.Show($"Сотрудник с номером {employeeNumber} был удалён."); // Вывод сообщения об успехе
                }
                else
                {
                    MessageBox.Show("Сотрудник с таким номером не найден."); // Вывод сообщения об ошибке
                }
            }
            else
            {
                MessageBox.Show("Введите корректный номер."); // Вывод сообщения об ошибке
            }
            textBox_delete.Text = ""; // Очистка текстового поля для номера
        }
        // Метод для пересчёта номеров сотрудников после удаления
        private void RecalculateEmployeeNumbers()
        {
            number = 1; // Сброс счётчика нумерации
            foreach (var employee in employeeList)
            {
                employee.numbers = number++; // Перенумерация
            }
            UpdateEmployeeTable(); // Обновление таблицы
        }
        // Метод для обновления данных в таблице после удаления
        private void UpdateEmployeeTable()
        {
            tableEmployee.Rows.Clear(); // Очистка таблицы
            // Повторное заполнение таблицы актуальными данными
            foreach (var emp in employeeList)
            {
                tableEmployee.Rows.Add(emp.numbers, emp.surname, emp.name, emp.patronymic, emp.post, emp.salary, emp.Financee());
            }
        }
        // Класс Employee с методом Financee для расчёта годового дохода
        public class Employee
        {
            // Переменные
            public int numbers;
            public string surname;
            public string name;
            public string patronymic;
            public string post;
            public string salary;
            public string? Finaceyear;
            // Конструктор класса Employee
            public Employee(int number, string surname, string name, string patronymic, string post, string salary, string? Finaceyear)
            {
                this.numbers = number;
                this.surname = surname;
                this.name = name;
                this.patronymic = patronymic;
                this.post = post;
                this.salary = salary;
                this.Finaceyear = Finaceyear;
            }
            // Метод Financee для расчёта годового дохода
            public string Financee()
            {
                double zar = double.Parse(salary ?? "0");
                double yearFinance = zar * 12;
                Finaceyear = yearFinance.ToString("F2"); // Преобразование в строку с двумя знаками после запятой
                return Finaceyear;
            }
        }
    }
}
