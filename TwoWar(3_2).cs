namespace Mod_2
{
    public partial class TwoWar_3_2_ : Form
    {
        List<Obj> objects = new List<Obj>();   // Создание нового списка для объектов

        public TwoWar_3_2_()
        {
            InitializeComponent();
            // Отключение элементов управления
            textBox_number.Enabled = false;
            textBox_text.Enabled = false;
            button_AddObj.Enabled = false;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            // Включение элементов управления
            textBox_number.Enabled = true;
            textBox_text.Enabled = true;
            button_AddObj.Enabled = true;
        }
        private void button_AddDefault_Click(object sender, EventArgs e)
        {
            // Создание объекта по умолчанию и добавление его в список
            Obj obj1 = new Obj();
            objects.Add(obj1);
            Add(); // Обновление панели с объектами
        }
        private void button_Del_Click(object sender, EventArgs e)
        {
            // Очистка списка объектов
            objects.Clear();
            flowLayoutPanel1.Controls.Clear();  // Очистка панели
            // Вызов сборщика мусора и ожидание завершения финализаторов
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void button_AddObj_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(textBox_number.Text) || string.IsNullOrWhiteSpace(textBox_text.Text))
                {
                    MessageBox.Show("Введите корректные данные."); // Вывод сообщения
                    return;
                }
                // Преобразование строки в число с обработкой исключений
                if (!int.TryParse(textBox_number.Text, out int number))
                {
                    MessageBox.Show("Введите корректный номер."); // Вывод ошибки
                    return;
                }
                string text = textBox_text.Text;
                // Создание нового объекта и добавление его в список
                Obj newObj = new Obj(number, text);
                objects.Add(newObj);
                Add(); // Обновление панели с объектами
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message); // Вывод ошибки
            }
            finally
            {
                // Очистка текстовых полей и отключение элементов управления
                textBox_number.Clear();
                textBox_text.Clear();
                textBox_number.Enabled = false;
                textBox_text.Enabled = false;
                button_AddObj.Enabled = false;
            }
        }
        // Подпрограмма для добавления элементов на панель
        private void Add()
        {
            flowLayoutPanel1.Controls.Clear();  // Очистка предыдущих элементов
            foreach (Obj obj in objects)
            {
                // Настройки для flowLayoutPanel1
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel1.WrapContents = false;

                // Создание панели для каждого объекта
                Panel panel = new Panel
                {
                    Width = flowLayoutPanel1.Width - 25,
                    Height = 100,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Формирование текста для метки
                string labelText = $"Объект:\nномер = {obj.Number}\nтекст = {obj.Text}";

                // Создание метки для отображения информации об объекте
                Label label = new Label
                {
                    Text = labelText,  // Отображение информации об объекте
                    AutoSize = true
                };

                panel.Controls.Add(label); // Добавление метки в панель
                flowLayoutPanel1.Controls.Add(panel); // Добавление панели в flowLayoutPanel
            }
        }
        // Класс Obj
        class Obj
        {
            // Две переменные
            public int Number { get; private set; }
            public string Text { get; private set; }
            // Конструктор с входными параметрами
            public Obj(int number, string text)
            {
                Number = number;
                Text = text;
            }
            // Конструктор по умолчанию
            public Obj()
            {
                Number = 0;
                Text = "default";
            }
            // Деструктор
            ~Obj()
            {
                // Вывод системного уведомления при удалении объекта
                MessageBox.Show($"Объект с номером = {Number} и текстом = {Text} был удален.");
            }
        }
    }
}
