using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class Monitor : Form
    {

      private  KompasProgramm _kompasProgramClass = new KompasProgramm();
      private  MonitorSetting _monitorSetting = new MonitorSetting();

        public Monitor()
        {
            
            InitializeComponent();
            comboBoxScreenRatio.SelectedIndex = 2;
        }
      
        private void BuildModel_Click(object sender, EventArgs e )
        {
            try
            {

                    _monitorSetting.MonitorWight = Convert.ToDouble(_textBoxWightMonitor.Text);
                    _monitorSetting.MonitorHeight = Convert.ToDouble(_textBoxHeightMonitor.Text);
                    _monitorSetting.StandHeight = Convert.ToDouble(_textBoxHeightStande.Text);
                    _monitorSetting.StandeWight = Convert.ToDouble(_textBoxWigthStande.Text);
                    _monitorSetting.Radius = Convert.ToDouble(_textBoxRadius.Text);

                    _kompasProgramClass.SetParametr(_monitorSetting);

                    _kompasProgramClass.Construct();

                
            
    
            }
            catch(FormatException)
            {
                MessageBox.Show("У вас остались пустые поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _textBoxHeightMonito_Leave(object sender, EventArgs e)
        {
            try
            {
                
                _monitorSetting.MonitorHeight = Convert.ToDouble(_textBoxHeightMonitor.Text);
                _textBoxWightMonitor.Text = Convert.ToString(_monitorSetting.MonitorWight); 
                
            }
            catch (MonitorSettings.ExceptionFolder.HeightMonitorException)
            {
                _textBoxHeightMonitor.Clear();
                _textBoxHeightMonitor.Select();
                MessageBox.Show("Неправильно задана высота", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                _textBoxHeightMonitor.Clear();
                _textBoxHeightMonitor.Select();
                MessageBox.Show("Вы не ввели значение высоты", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _textBoxWightMonitor_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.MonitorWight = Convert.ToDouble(_textBoxWightMonitor.Text);
                _textBoxHeightMonitor.Text = Convert.ToString(_monitorSetting.MonitorHeight);
            }
            catch (FormatException)
            {
                _textBoxWightMonitor.Clear();
                _textBoxWightMonitor.Select();
                MessageBox.Show("Вы не ввели значение высоты", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MonitorSettings.ExceptionFolder.WightMonitorException)
            {
                _textBoxWightMonitor.Clear();
                _textBoxWightMonitor.Select();
                MessageBox.Show("Вы не правильно ввели ширину монитора", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _textBoxHeightStande_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.StandHeight = Convert.ToDouble(_textBoxHeightStande.Text);
            }
            catch (FormatException)
            {
                _textBoxHeightStande.Clear();
                _textBoxHeightStande.Select();
                MessageBox.Show("Вы не ввели значение высоты подставки", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MonitorSettings.ExceptionFolder.HeightStandeException)
            {
                _textBoxHeightStande.Clear();
                _textBoxHeightStande.Select();
                MessageBox.Show("Вы не правильно ввели высоту подставки", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _textBoxWigthStande_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.StandeWight = Convert.ToDouble(_textBoxWigthStande.Text);
            }
            catch (MonitorSettings.ExceptionFolder.WightStandeException)
            {
                _textBoxWigthStande.Clear();
                _textBoxWigthStande.Select();
                MessageBox.Show("Вы не правильно ввели ширину подставки", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                _textBoxWigthStande.Clear();
                _textBoxWigthStande.Select();
                MessageBox.Show("Вы не ввели значение ширины подставки", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _textBoxRadius_Leave(object sender, EventArgs e)
        {
            try
            {
                _monitorSetting.Radius = Convert.ToDouble(_textBoxRadius.Text);
            }
            catch (MonitorSettings.ExceptionFolder.RadiusException)
            {
                _textBoxRadius.Clear();
                _textBoxRadius.Select();
                MessageBox.Show("Вы не правильно ввели радиус нижней части подставки", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                _textBoxRadius.Clear();
                _textBoxRadius.Select();
                MessageBox.Show("Вы не ввели значение Радиуса", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedItem.ToString())
            {
                case "4 : 3" :
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

        private void AspectRatio_SelectedValueChanged(object sender, EventArgs e)
        {
            _textBoxHeightMonitor.Clear();
            _textBoxWightMonitor.Clear();
            _textBoxWigthStande.Clear();
            _textBoxHeightStande.Clear();
            _textBoxRadius.Clear();
        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBox_DisplayMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
