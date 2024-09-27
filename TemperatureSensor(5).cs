using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mod_2
{
    public partial class TemperatureSensor_5_ : Form
    {
        // Экземпляры классов датчика температуры и термостата
        private TemperatureSensor temperatureSensor;
        private Thermostat thermostat;

        public TemperatureSensor_5_()
        {
            InitializeComponent();

            // Инициализация "датчика" температуры и термостата
            temperatureSensor = new TemperatureSensor();
            thermostat = new Thermostat();

            // Подписка термостата на событие изменения температуры
            temperatureSensor.TemperatureChanged += (sender, e) =>
            {
                    // Вызов метода термостата при изменении температуры
                    thermostat.OnTemperatureChanged(sender, e, textBox_info);
            };
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            textBox_info.Text = ""; // Очистка поля для вывода информации
            // Проверка на то, что поле ввода температуры не пустое
            if (!string.IsNullOrEmpty(textBox_Check.Text))
            {
                // Попытка преобразовать введенное значение в тип float
                if (float.TryParse(textBox_Check.Text, out float temperature))
                {
                    // Если преобразование успешно, присвоить значение текущей температуре датчика
                    temperatureSensor.CurrentTemperature = temperature;
                }
            }
            // Если поле пустое, вывод сообщения об ошибке
            else
            {
                MessageBox.Show("Поле температуры не может быть пустым.");
            }
        }
    }
    // Делегат для события изменения температуры
    public delegate void TemperatureChangedHandler(object sender, TemperatureChangedEventArgs e);

    // Класс для хранения данных о температуре
    public class TemperatureChangedEventArgs : EventArgs
    {
        // Свойство для хранения нового значения температуры
        public float NewTemperature { get; }

        // Конструктор класса TemperatureChangedEventArgs
        public TemperatureChangedEventArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }
    // Класс датчика температуры
    public class TemperatureSensor
    {
        private float _currentTemperature; // Поле для хранения текущей температуры
        public event TemperatureChangedHandler TemperatureChanged = delegate { };

        public float CurrentTemperature // Свойство для изменения и получения текущей температуры
        {
            get => _currentTemperature;
            set
            {
                // Если значение температуры изменилось
                if (_currentTemperature != value)
                {
                    _currentTemperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_currentTemperature)); // Вызов события изменения температуры
                }
            }
        }
        // Метод для вызова события TemperatureChanged
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e); // Если на событие подписаны обработчики, оно вызывается
        }
    }
    // Класс термостата
    public class Thermostat
    {        
        private const float HeatingThreshold = 20.0f; // Пороговое значение для включения отопления

        // Метод обработки изменения температуры
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e, TextBox textBox_info)
        {
            // Если температура ниже порогового значения, включить отопление
            if (e.NewTemperature < HeatingThreshold)
            {
                string info = "Отопление включено.";
                textBox_info.Text = info;
            }
            // Если температура выше порогового значения, выключить отопление
            else
            {
                string info = "Отопление выключено.";
                textBox_info.Text = info;
            }
        }
    }
}
