using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mod_2
{
    public partial class Drawable_4_ : Form
    {
        private List<IDrawable> shapes = new List<IDrawable>(); // Список для хранения объектов

        public Drawable_4_()
        {
            InitializeComponent();
            // Отключение всех полей ввода
            textBox_radius.Enabled = false;
            textBox_width.Enabled = false;
            textBox_length.Enabled = false;
            textBox_triangle1.Enabled = false;
            textBox_triangle2.Enabled = false;
            textBox_triangle3.Enabled = false;
            textBox_info.Enabled = false;
            panel_drawing.BackColor = Color.White; // Установка белого фона для панели рисования
        }
        private void draw_Circle_Click(object sender, EventArgs e)
        {
            // Включение ввода только для радиуса
            textBox_radius.Enabled = true;
            textBox_width.Enabled = false;
            textBox_length.Enabled = false;
            textBox_triangle1.Enabled = false;
            textBox_triangle2.Enabled = false;
            textBox_triangle3.Enabled = false;
        }
        private void draw_Rectangle_Click(object sender, EventArgs e)
        {
            // Включение ввода только для ширины и длины
            textBox_radius.Enabled = false;
            textBox_width.Enabled = true;
            textBox_length.Enabled = true;
            textBox_triangle1.Enabled = false;
            textBox_triangle2.Enabled = false;
            textBox_triangle3.Enabled = false;
        }
        private void draw_Triangle_Click(object sender, EventArgs e)
        {
            // Включение ввода только для сторон треугольника
            textBox_radius.Enabled = false;
            textBox_width.Enabled = false;
            textBox_length.Enabled = false;
            textBox_triangle1.Enabled = true;
            textBox_triangle2.Enabled = true;
            textBox_triangle3.Enabled = true;
        }
        private void Drawing_Click(object sender, EventArgs e)
        {
            panel_drawing.Invalidate(); // Очистка панели перед отрисовкой новой фигуры
            shapes.Clear(); // Очистка списка фигур
            // Проверка, активировано ли поле радиуса и заполнено ли оно
            if (textBox_radius.Enabled && !string.IsNullOrEmpty(textBox_radius.Text))
            {
                double radius = double.Parse(textBox_radius.Text);
                shapes.Add(new Circle(radius)); // Добавление фигуры круг в список
            }
            // Проверка полей ширины и длины для прямоугольника и заполнены ли они
            else if (textBox_width.Enabled && textBox_length.Enabled && !string.IsNullOrEmpty(textBox_width.Text) && !string.IsNullOrEmpty(textBox_length.Text))
            {
                double width = double.Parse(textBox_width.Text);
                double length = double.Parse(textBox_length.Text);
                shapes.Add(new Rectangle(width, length)); // Добавление фигуры прямоугольник в список
            }
            // Проверка полей для сторон треугольника
            else if (textBox_triangle1.Enabled && textBox_triangle2.Enabled && textBox_triangle3.Enabled && !string.IsNullOrEmpty(textBox_triangle1.Text) && !string.IsNullOrEmpty(textBox_triangle2.Text) && !string.IsNullOrEmpty(textBox_triangle3.Text))
            {
                double triangle1 = double.Parse(textBox_triangle1.Text);
                double triangle2 = double.Parse(textBox_triangle2.Text);
                double triangle3 = double.Parse(textBox_triangle3.Text);
                shapes.Add(new Triangle(triangle1, triangle2, triangle3)); // Добавление фигуры треугольник в список
            }
            else
            {
                // Вывод сообщения об ошибке
                MessageBox.Show("Введите корректные данные");
                return;
            }
            // Перерисовка фигуры
            panel_drawing.Paint += (s, pe) =>
            {
                Graphics g = pe.Graphics;
                foreach (var shape in shapes)
                {
                    shape.Draw(panel_drawing, g, textBox_info); // Передача ссылки на textBox_info
                }
            };
            panel_drawing.Refresh();
            // Очистка и отключение полей для ввода
            textBox_radius.Enabled = false;
            textBox_width.Enabled = false;
            textBox_length.Enabled = false;
            textBox_triangle1.Enabled = false;
            textBox_triangle2.Enabled = false;
            textBox_triangle3.Enabled = false;
            textBox_radius.Text = "";
            textBox_width.Text = "";
            textBox_length.Text = "";
            textBox_triangle1.Text = "";
            textBox_triangle2.Text = "";
            textBox_triangle3.Text = "";
        }
        // Интерфейс IDrawable
        public interface IDrawable
        {
            void Draw(Panel panel_drawing, Graphics g, TextBox textBoxInfo); // Процедура void и её параметры 
        }
        // Класс Circle наследуемуй от интерфейса IDrawable
        public class Circle : IDrawable
        {
            public double Radius { get; set; }

            public Circle(double radius) // Конструктор круга
            {
                Radius = radius;
            }
            public void Draw(Panel panel_drawing, Graphics g, TextBox textBoxInfo)
            {
                // Вычисление центра панели и координат для отрисовки
                double centerX = panel_drawing.Width / 2;
                double centerY = panel_drawing.Height / 2;
                double topLeftX = centerX - Radius;
                double topLeftY = centerY - Radius;

                g.DrawEllipse(Pens.Black, (float)topLeftX, (float)topLeftY, (float)(Radius * 2), (float)(Radius * 2)); // Рисуем круг
                textBoxInfo.Text = Info(); // Вывод информации о круге
            }
            public string Info() => $"Круг с радиусом: {Radius}"; // Информация о круге
        }

        // Класс Rectangle наследуемуй от интерфейса IDrawable
        public class Rectangle : IDrawable
        {
            public double Width { get; set; }
            public double Length { get; set; }

            public Rectangle(double width, double length) // Конструктор прямоугольника
            {
                Width = width;
                Length = length;
            }
            public void Draw(Panel panel_drawing, Graphics g, TextBox textBoxInfo)
            {
                // Вычисление центра панели и координат для отрисовки
                double centerX = panel_drawing.Width / 2;
                double centerY = panel_drawing.Height / 2;
                double topLeftX = centerX - Width / 2;
                double topLeftY = centerY - Length / 2;

                g.DrawRectangle(Pens.Black, (float)topLeftX, (float)topLeftY, (float)Width, (float)Length); // Рисовка прямоугольник
                textBoxInfo.Text = Info(); // Вывод информации о прямоугольнике
            }
            public string Info() => $"Прямоугольник с шириной: {Width}, длиной: {Length}"; // Информация о прямоугольнике
        }
        // Класс Triangle наследуемуй от интерфейса IDrawable
        public class Triangle : IDrawable
        {
            public double Triangle1 { get; set; }
            public double Triangle2 { get; set; }
            public double Triangle3 { get; set; }

            public Triangle(double side1, double side2, double side3) // Конструктор треугольника
            {
                Triangle1 = side1;
                Triangle2 = side2;
                Triangle3 = side3;
            }
            public void Draw(Panel panel_drawing, Graphics g, TextBox textBoxInfo)
            {
                // Заглушка для рисования треугольника, так как отрисовка сложна в реализации
                g.DrawString("Треугольник", new Font("Arial", 30), Brushes.Black, new Point(10, 10)); // Текст на панели
                textBoxInfo.Text = Info(); // Вывод информации о треугольнике
            }
            public string Info() => $"Треугольник со сторонами: {Triangle1}, {Triangle2}, {Triangle3}"; // Информация о треугольнике
        }
    }
}
