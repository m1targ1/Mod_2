using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mod_2
{
    public partial class ClassPerson_1_ : Form
    {
        List<Person> people = new List<Person>();   // Созздание нового списка для людей
        public ClassPerson_1_()
        {
            InitializeComponent();
        }

        private void Add_Person_Click(object sender, EventArgs e)
        {
            // Вкючение полей для ввода данных и кнопки "Добавить" 
            textBox_FIO.Enabled = true;
            textBox_Age.Enabled = true;
            textBox_Adress.Enabled = true;
            Add_to_list.Enabled = true;
        }
        private void Add_to_list_Click(object sender, EventArgs e)
        {
            // Условие если поля пусты
            if (textBox_FIO.Text == "" || textBox_Age.Text == "" || textBox_Adress.Text == "")
            {
                MessageBox.Show("Введите корректные данные");   // Выввод сообщения
            }
            else
            {
                // Иначе добавление человека и данных о нём в список
                string name = textBox_FIO.Text;
                string age = textBox_Age.Text;
                string address = textBox_Adress.Text;
                // Создание нового объекта в списке Person
                Person newPerson = new Person(name, age, address);
                people.Add(newPerson);
            }
            // Очистка текстовых полей
            textBox_FIO.Clear();
            textBox_Age.Clear();
            textBox_Adress.Clear();
            // Отключение текстовых полей и кнопки
            textBox_FIO.Enabled = false;
            textBox_Age.Enabled = false;
            textBox_Adress.Enabled = false;
            Add_to_list.Enabled = false;
            flowLayoutPanel1.Controls.Clear(); // Очистка панели для вывода списка пользователей
        }
        public void Check_List_person_Click(object sender, EventArgs e)
        {
            if (people.Count == 0)
            {
                MessageBox.Show("Нет данных для вывода");   // Выввод сообщения
            }
            else 
            {
                flowLayoutPanel1.Controls.Clear();  // Очистка предыдущих элементов
                int personCount = 1;  // Счетчик для людей
                foreach (Person person in people)
                {
                    // Настройки для flowLayoutPanel1
                    flowLayoutPanel1.AutoScroll = true;
                    flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                    flowLayoutPanel1.WrapContents = false;
                    // Создание панели для каждого человека
                    Panel panel = new Panel
                    {
                        Width = flowLayoutPanel1.Width - 25,
                        Height = 100,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    string labelText = $"Человек №{personCount}: {person}"; // Формирование первой строки с номером человека

                    // Создание метки для отображения информации о человеке
                    Label label = new Label
                    {
                        Text = labelText,  // Использование счётчик и ToString() для вывода
                        AutoSize = true
                    };
                    panel.Controls.Add(label); // Добавление метки в панель                
                    flowLayoutPanel1.Controls.Add(panel); // Добавление панели в flowLayoutPanel                
                    personCount++; // Увеличение счётчика
                }
            }
        }
    }
    // Класс Person с переопределением метода ToString
    class Person
    {
        // Переменные
        private string name;
        private string age;
        private string address;

        public Person(string name, string age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        // Метод ToString для корректного отображения
        public override string ToString()
        {
            return $"\nИмя: {name}\nВозраст: {age}\nАдрес: {address}";
        }
        public string GetName() { return name; }
        public string GetAge() { return age; }
        public string GetAddress() { return address; }
    }
}
