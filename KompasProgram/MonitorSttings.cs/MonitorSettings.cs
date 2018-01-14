using MonitorSettings.ExceptionFolder;

namespace MonitorSettings
{
    /// <summary>
    /// Параметры монитора
    /// </summary>
    public class MonitorSetting
    {
        /// <summary>
        /// Высота монитора
        /// </summary>
        private double _monitorHeight;

        /// <summary>
        /// Ширина монитора
        /// </summary>
        private double _monitorWight;

        /// <summary>
        /// Высота подставки
        /// </summary>
        private double _standHeight;

        /// <summary>
        /// Ширина подставки
        /// </summary>
        private double _standWight;

        /// <summary>
        /// Радиус нижней части детали
        /// </summary>
        private double _radius;

        /// <summary>
        /// Выбор разрешения экрана
        /// </summary>
        public ScreenRatio ScreenRatio
        {
            get; set;
        }

        /// <summary>
        /// Свойства высоты монитора
        /// </summary>
        public double MonitorHeight
        {
            get
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                    {
                        if (_monitorWight > 0)
                        {
                            return _monitorHeight = _monitorWight * 0.5625;
                        }
                        return _monitorHeight;
                    }
                    case ScreenRatio.ThreeByTwo:
                    {
                        if (_monitorWight > 0)
                        {
                            return _monitorHeight = _monitorWight / 1.5;
                        }
                        return _monitorHeight;
                    }
                    case ScreenRatio.FourByTrhee:
                    {
                        if (_monitorWight > 0)
                        {
                                return _monitorHeight = _monitorWight * .75;
                        }
                            return _monitorHeight;
                    }
                }
                return _monitorHeight;
            }
            set
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                        {
                            if (value > 720 || value < 360)
                            {
                                throw new HeightMonitorException();
                            }
                            _monitorHeight = value;
                            break;
                        }
                    case ScreenRatio.FourByTrhee:
                        {
                            if (value > 360 || value < 180)
                            {
                                throw new HeightMonitorException();
                            }
                            _monitorHeight = value;
                            break;
                        }
                    case ScreenRatio.ThreeByTwo:
                        {
                            if (value > 240 || value < 120)
                            {
                                throw new HeightMonitorException();
                            }
                            _monitorHeight = value;
                            break;
                        }
                }
                _monitorHeight = value;
            }
        }

        /// <summary>
        /// Свойство ширины монитора
        /// </summary>
        public double MonitorWight
        {
            get
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                        {
                            if (_monitorHeight > 0)
                            {
                                return _monitorWight = _monitorHeight / 0.5625;
                            }
                            return _monitorWight;
                        }
                    case ScreenRatio.ThreeByTwo:
                        {
                            if (_monitorHeight > 0)
                            {
                                return _monitorWight = _monitorHeight * 1.5;
                            }
                            return _monitorWight;
                        }
                    case ScreenRatio.FourByTrhee:
                        {
                            if (_monitorHeight > 0)
                            {
                                return _monitorWight = _monitorHeight / .75;
                            }
                            return _monitorWight;
                        }
                }
                return _monitorWight;
            }
            set
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                        {
                            if (value > 1280 || value < 640)
                            {
                                throw new WightMonitorException();
                            }
                            _monitorWight = value;
                            break;
                        }
                    case ScreenRatio.FourByTrhee:
                        {
                            if (value > 480 || value < 240)
                            {
                                throw new WightMonitorException();
                            }
                            _monitorWight = value;
                            break;
                        }
                    case ScreenRatio.ThreeByTwo:
                        {
                            if (value > 360 || value < 180)
                            {
                                throw new WightMonitorException();
                            }
                            _monitorWight = value;
                            break;
                        }
                }
                _monitorWight = value;
            }
        }

        /// <summary>
        /// Свойство высоты подставки
        /// </summary>
        public double StandHeight
        {
            get
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                        {
                            if (_monitorWight > 0)
                            {
                                return _standHeight;
                            }
                            return _standHeight;
                        }
                    case ScreenRatio.ThreeByTwo:
                        {
                            if (_standHeight > 0)
                            {
                                return _standHeight;
                            }
                            return _standHeight;
                        }
                    case ScreenRatio.FourByTrhee:
                        {
                            if (_monitorHeight > 0)
                            {
                                return _standHeight;
                            }
                            return _standHeight;
                        }
                }
                return _standHeight;
            }
            set
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                        {
                            if (value > 650 || value < 500)
                            {
                                throw new HeightStandeException();
                            }
                            _standHeight = value;
                            break;
                        }
                    case ScreenRatio.FourByTrhee:
                        {
                            if (value > 450 || value < 350)
                            {
                                throw new HeightStandeException();
                            }
                            _standHeight = value;
                            break;
                        }
                    case ScreenRatio.ThreeByTwo:
                        {
                            if (value > 400 || value < 300)
                            {
                                throw new HeightStandeException();
                            }
                            _standHeight = value;
                            break;
                        }
                }
                _standHeight = value;
            }
        }

        /// <summary>
        /// Свойства ширины подставки
        /// </summary>
        public double StandeWight
        {
            get
            {
                return _standWight;
            }
            set
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                        {
                            if (value > 150 || value < 100)
                            {
                                throw new WightStandeException();
                            }
                            _standWight = value;
                            break;
                        }
                    case ScreenRatio.FourByTrhee:
                        {
                            if (value > 125 || value < 90)
                            {
                                throw new WightStandeException();
                            }
                            _standWight = value;
                            break;
                        }
                    case ScreenRatio.ThreeByTwo:
                        {
                            if (value > 90 || value < 50)
                            {
                                throw new WightStandeException();
                            }
                            _standWight = value;
                            break;
                        }
                }
                _standWight = value;
            }
        }

        /// <summary>
        /// Свойства радиуса нижней части подставки
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                switch (ScreenRatio)
                {
                    case ScreenRatio.SixteenOnNine:
                        {
                            if (value > 350 || value < 275)
                            {
                                throw new RadiusException();
                            }
                            _radius = value;
                            break;
                        }
                    case ScreenRatio.FourByTrhee:
                        {
                            if (value > 275 || value < 225)
                            {
                                throw new RadiusException();
                            }
                            _radius = value;
                            break;
                        }
                    case ScreenRatio.ThreeByTwo:
                        {
                            if (value > 250 || value < 200)
                            {
                                throw new RadiusException();
                            }
                            _radius = value;
                            break;
                        }
                }
            }
        }
    }
}
