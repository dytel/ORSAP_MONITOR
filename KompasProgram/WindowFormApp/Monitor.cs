using System;
using System.Windows.Forms;
using MonitorSettings;
using KompasPrograms;
using MonitorSettings.ExceptionFolder;

namespace WindowFormApp
{
    public partial class Monitor : Form
    {
        /// <summary>
        /// создание объекта конструирования детали
        /// </summary>
        private KompasProgram _kompasProgram = new KompasProgram();

        /// <summary>
        /// Создание объекта параметров монитора
        /// </summary>
        private MonitorSetting _monitorSetting = new MonitorSetting();

        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public Monitor()
        {
            InitializeComponent();
            comboBoxScreenRatio.SelectedIndex = 2;
        }

        /// <summary>
        /// Включение компаса и построение модели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildModel_Click(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.MonitorWight =
                    Convert.ToDouble(_textBoxWightMonitor.Text);
                _monitorSetting.MonitorHeight =
                    Convert.ToDouble(_textBoxHeightMonitor.Text);
                _monitorSetting.StandHeight =
                    Convert.ToDouble(_textBoxHeightStande.Text);
                _monitorSetting.StandeWight =
                    Convert.ToDouble(_textBoxWigthStande.Text);
                _monitorSetting.Radius = Convert.ToDouble(_textBoxRadius.Text);
                _kompasProgram.SetParametr(_monitorSetting);
                _kompasProgram.Construct();
            }
            catch (FormatException)
            {
                MessageBox.Show("У вас остались пустые поля", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Выбор разрешения экрана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedItem.ToString())
            {
                case "4 : 3":
                    _monitorSetting.ScreenRatio = ScreenRatio.FourByTrhee;
                    break;
                case "16 : 9":
                    _monitorSetting.ScreenRatio = ScreenRatio.SixteenOnNine;
                    break;
                case "3 : 2":
                    _monitorSetting.ScreenRatio = ScreenRatio.ThreeByTwo;
                    break;
                default:
                    _monitorSetting.ScreenRatio = ScreenRatio.FourByTrhee;
                    break;
            }
        }

        /// <summary>
        /// Валидация Высоты монитора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxHeightMonitor_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.MonitorHeight =
                    Convert.ToDouble(_textBoxHeightMonitor.Text);
                _textBoxWightMonitor.Text =
                    Convert.ToString(_monitorSetting.MonitorWight);
            }
            catch (HeightMonitorException)
            {
                SelectedTextBox(_textBoxHeightMonitor,
                    "Неправильно задана высота");
            }
            catch (FormatException)
            {
                SelectedTextBox(_textBoxHeightMonitor,
                    "Вы не ввели значение высоты монитора");
            }
        }

        /// <summary>
        /// Валидация ширины монитора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxWightMonitor_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.MonitorWight =
                    Convert.ToDouble(_textBoxWightMonitor.Text);
                _textBoxHeightMonitor.Text =
                    Convert.ToString(_monitorSetting.MonitorHeight);
            }
            catch (FormatException)
            {
                SelectedTextBox(_textBoxWightMonitor,
                    "Вы не ввели значение ширины монитора");
            }
            catch (WightMonitorException)
            {
                SelectedTextBox(_textBoxWightMonitor, "Неправильно задана ширина");
            }
        }

        /// <summary>
        /// Валидация Высоты подставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxHeightStande_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.StandHeight =
                    Convert.ToDouble(_textBoxHeightStande.Text);
            }
            catch (FormatException)
            {
                SelectedTextBox(_textBoxHeightStande,
                    "Вы не ввели значение высоты подставки");
            }
            catch (HeightStandeException)
            {
                SelectedTextBox(_textBoxHeightStande,
                    "Неправильно задана высота подставки");
            }
        }

        /// <summary>
        /// Валидация ширины подставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxWigthStande_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.StandeWight =
                    Convert.ToDouble(_textBoxWigthStande.Text);
            }
            catch (WightStandeException)
            {
                SelectedTextBox(_textBoxWigthStande,
                    "Неправильно задана ширина монитора");
            }
            catch (FormatException)
            {
                SelectedTextBox(_textBoxWigthStande,
                    "Вы не ввели значение ширину подставки");
            }
        }

        /// <summary>
        /// Валидация радиуса нижней части подставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxRadius_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.Radius = Convert.ToDouble(_textBoxRadius.Text);
            }
            catch (RadiusException)
            {
                SelectedTextBox(_textBoxRadius, "Неправильно задан радиус");
            }
            catch (FormatException)
            {
                SelectedTextBox(_textBoxRadius, "Вы не ввели значение радиуса");
            }
        }

        /// <summary>
        /// шаблон валидации
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        private void SelectedTextBox(TextBox textBox, string message)
        {
            textBox.Clear();
            textBox.Select();
            MessageBox.Show(message, "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}