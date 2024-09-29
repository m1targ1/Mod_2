namespace Mod_2
{
    public partial class ClassShape_2_ : Form
    {
        public ClassShape_2_()
        {
            InitializeComponent();
        }
        private void Button_Circle_Click(object sender, EventArgs e)
        {
            // Включение и отключение компонентов для работы
            textBox_Radius.Enabled = true;
            buttonCircle_calc.Enabled = true;
            textBox_Width.Enabled = false;
            textBox_Length.Enabled = false;
            buttonRectangle_calc.Enabled = false;
        }
        private void Button_Rectangle_Click(object sender, EventArgs e)
        {
            // Включение и отключение компонентов для работы
            textBox_Radius.Enabled = false;
            buttonCircle_calc.Enabled = false;
            textBox_Width.Enabled = true;
            textBox_Length.Enabled = true;
            buttonRectangle_calc.Enabled = true;
        }
        private void buttonCircle_calc_Click(object sender, EventArgs e)
        {
            string inputRadius = textBox_Radius.Text; // Переменная для радиуса
            try
            {
                // Попытка преобразовать строку в число
                double radius = double.Parse(inputRadius);
                // Создание объекта Circle и расчет площади и периметра
                Circle circle = new Circle(radius);
                circle.Area();
                circle.Perimetr();
                // Вывод результатов
                circle.Print(textBox_Area, textBox_Perimetr);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение радиуса.");
            }
            // Очистка поля и отключение компонентов
            textBox_Radius.Text = "";
            textBox_Radius.Enabled = false;
            buttonCircle_calc.Enabled = false;
        }
        private void buttonRectangle_calc_Click(object sender, EventArgs e)
        {
            string inputWidth = textBox_Width.Text; // Переменная для ширины
            string inputLength = textBox_Length.Text; // Переменная для длины
            try
            {
                // Попытка преобразовать строку в число
                double weight = double.Parse(inputWidth);
                double lenght = double.Parse(inputLength);

                // Создание объекта Circle и расчет площади и периметра
                Rectangle rectangle = new Rectangle(weight, lenght);
                rectangle.Area();
                rectangle.Perimetr();

                // Вывод результатов
                rectangle.Print(textBox_Area, textBox_Perimetr);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения ширины и длины.");
            }
            // Очистка полей и отключение компонентов
            textBox_Width.Text = "";
            textBox_Length.Text = "";
            textBox_Width.Enabled = false;
            textBox_Length.Enabled = false;
            buttonRectangle_calc.Enabled = false;
        }
    }
    // Базовый класс Shape
    class Shape
    {
        // Свойства для площади, периметра, ширины, длины и радиуса
        public double area { get; set; }
        public double perimetr { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Radius { get; set; }

        // Виртуальный метод для вычисления площади (по умолчанию для прямоугольников)
        public virtual void Area()
        {
            area = Width * Length; // Вычисление площади
        }
        // Виртуальный метод для вычисления периметра (по умолчанию для прямоугольников)
        public virtual void Perimetr()
        {
            perimetr = 2 * (Width + Length); // Вычисление периметра
        }
        // Виртуальный метод для вывода площади и периметра в указанные текстовые поля
        public virtual void Print(TextBox textBox_Area, TextBox textBox_Perimeter)
        {
            textBox_Area.Text = $"{area}";
            textBox_Perimeter.Text = $"{perimetr}";
        }
    }
    // Производный класс Circle, наследуемый от Shape
    class Circle : Shape
    {
        // Конструктор принимает радиус в качестве параметра
        public Circle(double radius)
        {
            this.Radius = radius; // Присваивание значения радиуса
        }
        // Переопределённый метод для вычисления площади круга
        public override void Area()
        {
            area = Math.PI * Math.Pow(Radius, 2); // Вычисление площади окружности
        }
        // Переопределённый метод для вычисления периметра (длины окружности) окружности
        public override void Perimetr()
        {
            perimetr = 2 * Math.PI * Radius; // Вычисление периметра окружности
        }
    }
    // Производный класс Rectangle, наследуемый от Shape
    class Rectangle : Shape
    {
        // Конструктор принимает ширину и длину в качестве параметров
        public Rectangle(double width, double lenght)
        {
            this.Width = width; // Присваивание значения ширины
            this.Length = lenght; // Присваивание значения длины
        }
    }
}
