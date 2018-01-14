using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MonitorSettings;

namespace MonitorTest
{
    [TestFixture]
    public class MonitorTest
    {
        [Test]
        #region Тесты на высоту экрана
        [TestCase(360, ScreenRatio.SixteenOnNine,
            TestName = "Тест монитора  16 : 9 правильно заданной высоты")]
        [TestCase(180, ScreenRatio.FourByTrhee,
            TestName = "Тест монитора  4 : 3 правильно заданной высоты")]
        [TestCase(120, ScreenRatio.ThreeByTwo,
            TestName = "Тест монитора  3 : 2 правильно заданной высоты")]
        public void SetMonitorHeightSixteenOnNine_PossitiveTest(double HeightMonitor,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            monitor.MonitorHeight = HeightMonitor;
        }

        [TestCase(359, ScreenRatio.SixteenOnNine,
            TestName = "Тест монитора меньше 16 : 9 заданной высоты")]
        [TestCase(721, ScreenRatio.SixteenOnNine,
            TestName = "Тест монитора высоты 16 : 9 больше заданной высоты")]
        [TestCase(179, ScreenRatio.FourByTrhee,
            TestName = "Тест монитора высоты 4 : 3 меньше заданной высоты")]
        [TestCase(361, ScreenRatio.FourByTrhee,
            TestName = "Тест монитора высоты 4 : 3 больше заданной высоты")]
        [TestCase(119, ScreenRatio.ThreeByTwo,
            TestName = "Тест монитора высоты 3 : 2 меньше заданной высоты")]
        [TestCase(241, ScreenRatio.ThreeByTwo,
            TestName = "Тест монитора высоты 3 : 2  больше заданной высоты")]
        public void SetMonitorHeightSixteenOnNine_NegativTest(double HeightMonitor,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            Assert.Throws<MonitorSettings.ExceptionFolder.HeightMonitorException>(() =>
            monitor.MonitorHeight = HeightMonitor);
        }
        #endregion

        #region Тесты на ширину экрана
        [TestCase(640, ScreenRatio.SixteenOnNine,
            TestName = "Тест монитора  16 : 9 правильно заданной ширины")]
        [TestCase(480, ScreenRatio.FourByTrhee,
            TestName = "Тест монитора  4 : 3 правильно заданной ширины")]
        [TestCase(360, ScreenRatio.ThreeByTwo,
            TestName = "Тест монитора  3 : 2 правильно заданной ширины")]
        public void SetMonitorWighttSixteenOnNine_PossitiveTest(double WightMonitor,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            monitor.MonitorWight = WightMonitor;
        }

        [TestCase(639, ScreenRatio.SixteenOnNine,
            TestName = "Тест монитора меньше 16 : 9 заданной ширины")]
        [TestCase(1281, ScreenRatio.SixteenOnNine,
            TestName = "Тест монитора  16 : 9 больше заданной ширины")]
        [TestCase(481, ScreenRatio.FourByTrhee,
            TestName = "Тест монитора  4 : 3 больше заданной ширины")]
        [TestCase(239, ScreenRatio.FourByTrhee,
            TestName = "Тест монитора  4 : 3 меньше заданной ширины")]
        [TestCase(179, ScreenRatio.ThreeByTwo,
            TestName = "Тест монитора  3 : 2 больше заданной ширины")]
        [TestCase(361, ScreenRatio.ThreeByTwo,
            TestName = "Тест монитора  3 : 2 больше заданной Ширины")]
        public void SetMonitorWightSixteenOnNine_NegativMoreTest(double WightMonitor,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            Assert.Throws<MonitorSettings.ExceptionFolder.WightMonitorException>(() =>
            monitor.MonitorWight = WightMonitor);
        }
        #endregion

        #region Тест на высоту подставки
        [TestCase(500, ScreenRatio.SixteenOnNine,
            TestName = "Тест подставки  16 : 9 правильно заданной высоты")]
        [TestCase(350, ScreenRatio.FourByTrhee,
            TestName = "Тест подставки  4 : 3 правильно заданной высоты")]
        [TestCase(300, ScreenRatio.ThreeByTwo,
            TestName = "Тест подставки 3 : 2 правильно заданной высоты")]
        public void SetStandHeightSixteenOnNine_PossitiveTest(double HeightStand,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            monitor.StandHeight = HeightStand;
        }

        [TestCase(499, ScreenRatio.SixteenOnNine,
            TestName = "Тест подставки меньше 16 : 9 заданной высоты")]
        [TestCase(651, ScreenRatio.SixteenOnNine,
            TestName = "Тест подставки высоты 16 : 9 больше заданной высоты")]
        [TestCase(349, ScreenRatio.FourByTrhee,
            TestName = "Тест подставки высоты 4 : 3 меньше заданной высоты")]
        [TestCase(451, ScreenRatio.FourByTrhee,
            TestName = "Тест подставки высоты 4 : 3 больше заданной высоты")]
        [TestCase(299, ScreenRatio.ThreeByTwo,
            TestName = "Тест подставки высоты 3 : 2 меньше заданной высоты")]
        [TestCase(401, ScreenRatio.ThreeByTwo,
            TestName = "Тест подставки высоты 3 : 2 больше заданной высоты")]
        public void SetStandHeightThreeByTwo_NegativMoreTest(double HeightStand,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            Assert.Throws<MonitorSettings.ExceptionFolder.HeightStandeException>(() =>
            monitor.StandHeight = HeightStand);
        }
        #endregion
        #region Тест на ширину подставки
        [TestCase(100, ScreenRatio.SixteenOnNine,
            TestName = "Тест подставки  16 : 9 правильно заданной ширины")]
        [TestCase(90, ScreenRatio.FourByTrhee,
            TestName = "Тест подставки  4 : 3 правильно заданной ширины")]
        [TestCase(89, ScreenRatio.ThreeByTwo,
            TestName = "Тест подставки  3 : 2 правильно заданной ширины")]
        public void SetStandWightSixteenOnNine_PossitiveTest(double WightStand,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            monitor.StandeWight = WightStand;
        }

        [TestCase(99, ScreenRatio.SixteenOnNine,
            TestName = "Тест подставки 16 : 9 меньше заданной ширины")]
        [TestCase(151, ScreenRatio.SixteenOnNine,
            TestName = "Тест подставки 16 : 9 больше заданной ширины")]
        [TestCase(89, ScreenRatio.FourByTrhee,
            TestName = "Тест подставки  4 : 3 меньше заданной ширины")]
        [TestCase(500, ScreenRatio.FourByTrhee,
            TestName = "Тест подставки  4 : 3 больше заданной ширины")]
        [TestCase(500, ScreenRatio.ThreeByTwo,
            TestName = "Тест подставки 3 : 2 меньше заданной ширины")]
        [TestCase(49, ScreenRatio.ThreeByTwo,
            TestName = "Тест подставки 3 : 2 больше заданной ширины")]
        public void SetStandrWightSixteenOnNine_NegativMoreTest(double WightStand
            , ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = ScreenRatio.SixteenOnNine;
            Assert.Throws<MonitorSettings.ExceptionFolder.WightStandeException>(() =>
            monitor.StandeWight = WightStand);
        }
        #endregion

        #region Тест на радиус нижней части подставки
        [TestCase(275, ScreenRatio.SixteenOnNine,
            TestName = "Тест подставки  16 : 9 правильно заданном радиусе")]
        [TestCase(240, ScreenRatio.FourByTrhee,
            TestName = "Тест подставки  4 : 3 правильно заданном радиусе")]
        [TestCase(250, ScreenRatio.ThreeByTwo,
            TestName = "Тест подставки  3 : 2 правильно заданном радиусе")]
        public void SetRadiusSixteenOnNine_PossitiveTest(double Radius,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            monitor.Radius = Radius;
        }

        [TestCase(274, ScreenRatio.SixteenOnNine, TestName = "Тест радиус меньше 16 : 9 ")]
        [TestCase(351, ScreenRatio.SixteenOnNine, TestName = "Тест радиус больше 16 : 9 ")]
        [TestCase(276, ScreenRatio.FourByTrhee, TestName = "Тест радиус больше 4 : 3 ")]
        [TestCase(224, ScreenRatio.FourByTrhee, TestName = "Тест радиус меньше 4 : 3 ")]
        [TestCase(251, ScreenRatio.ThreeByTwo, TestName = "Тест радиус больше 3 : 2 ")]
        [TestCase(199, ScreenRatio.ThreeByTwo, TestName = "Тест радиус меньше 3 : 2 ")]
        public void SetRadiusSixteenOnNine_NegativMoreTest(double Radius,
            ScreenRatio screenRatio)
        {
            var monitor = new MonitorSetting();
            monitor.ScreenRatio = screenRatio;
            Assert.Throws<MonitorSettings.ExceptionFolder.RadiusException>(() =>
            monitor.Radius = Radius);
        }
        #endregion

    }
}
