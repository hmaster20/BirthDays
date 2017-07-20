using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Serialization;

namespace Days
{
    public class Settings
    {
        private static string fileName = "Settings.xml";
        private bool _useSeconds = true;
        private bool _useMinutes = true;
        private bool _useHours = true;
        private bool _useDays = true;
        private bool _useWeeks = true;
        private bool _useMonthes = true;
        private bool _useYears = true;
        private bool _calcEveryYear = true;
        private int _previousDaysQuantity = 7;
        private int _nextDaysQuantity = 30;
        private int _recountDaysQuantity = 7;
        private DateTime _lastRecalcDate = DateTime.MinValue;
        private bool _useSecondsStep = true;
        private bool _useMinutesStep = true;
        private bool _useHoursStep = true;
        private bool _useDaysStep = true;
        private bool _useWeeksStep = true;
        private bool _useMonthesStep = true;
        private bool _useExponentCalc = true;
        private bool _useSameDigitsCalc = true;
        private string _midNums = "2.5;7.5";
        private string _contactSort = "По именам";
        private int _secondsStep;
        private int _minutesStep;
        private int _hoursStep;
        private int _daysStep;
        private int _weeksStep;
        private int _monthesStep;

        [XmlElement("UseSeconds")]
        [DefaultValue(true)]
        public bool UseSeconds
        {
            get
            {
                return this._useSeconds;
            }
            set
            {
                this._useSeconds = value;
            }
        }

        [XmlElement("UseMinutes")]
        [DefaultValue(true)]
        public bool UseMinutes
        {
            get
            {
                return this._useMinutes;
            }
            set
            {
                this._useMinutes = value;
            }
        }

        [XmlElement("UseHours")]
        [DefaultValue(true)]
        public bool UseHours
        {
            get
            {
                return this._useHours;
            }
            set
            {
                this._useHours = value;
            }
        }

        [XmlElement("UseDays")]
        [DefaultValue(true)]
        public bool UseDays
        {
            get
            {
                return this._useDays;
            }
            set
            {
                this._useDays = value;
            }
        }

        [XmlElement("UseWeeks")]
        [DefaultValue(true)]
        public bool UseWeeks
        {
            get
            {
                return this._useWeeks;
            }
            set
            {
                this._useWeeks = value;
            }
        }

        [XmlElement("UseMonthes")]
        [DefaultValue(true)]
        public bool UseMonthes
        {
            get
            {
                return this._useMonthes;
            }
            set
            {
                this._useMonthes = value;
            }
        }

        [XmlElement("UseYears")]
        [DefaultValue(true)]
        public bool UseYears
        {
            get
            {
                return this._useYears;
            }
            set
            {
                this._useYears = value;
            }
        }

        [XmlElement("CalcEveryYear")]
        [DefaultValue(true)]
        public bool CalcEveryYear
        {
            get
            {
                return this._calcEveryYear;
            }
            set
            {
                this._calcEveryYear = value;
            }
        }

        [XmlElement("PreviousDaysQuantity")]
        [DefaultValue(7)]
        public int PreviousDaysQuantity
        {
            get
            {
                return this._previousDaysQuantity;
            }
            set
            {
                this._previousDaysQuantity = value;
            }
        }

        [XmlElement("NextDaysQuantity")]
        [DefaultValue(30)]
        public int NextDaysQuantity
        {
            get
            {
                return this._nextDaysQuantity;
            }
            set
            {
                this._nextDaysQuantity = value;
            }
        }

        [XmlElement("RecountDaysQuantity")]
        [DefaultValue(7)]
        public int RecountDaysQuantity
        {
            get
            {
                return this._recountDaysQuantity;
            }
            set
            {
                this._recountDaysQuantity = value;
            }
        }

        [XmlElement("LastRecalcDate")]
        public DateTime LastRecalcDate
        {
            get
            {
                return this._lastRecalcDate;
            }
            set
            {
                this._lastRecalcDate = value;
            }
        }

        [XmlElement("SecondsStep")]
        [DefaultValue(0)]
        public int SecondsStep
        {
            get
            {
                return this._secondsStep;
            }
            set
            {
                this._secondsStep = value;
            }
        }

        [XmlElement("UseSecondsStep")]
        [DefaultValue(true)]
        public bool UseSecondsStep
        {
            get
            {
                return this._useSecondsStep;
            }
            set
            {
                this._useSecondsStep = value;
            }
        }

        [XmlElement("MinutesStep")]
        [DefaultValue(0)]
        public int MinutesStep
        {
            get
            {
                return this._minutesStep;
            }
            set
            {
                this._minutesStep = value;
            }
        }

        [XmlElement("UseMinutesStep")]
        [DefaultValue(true)]
        public bool UseMinutesStep
        {
            get
            {
                return this._useMinutesStep;
            }
            set
            {
                this._useMinutesStep = value;
            }
        }

        [XmlElement("HoursStep")]
        [DefaultValue(0)]
        public int HoursStep
        {
            get
            {
                return this._hoursStep;
            }
            set
            {
                this._hoursStep = value;
            }
        }

        [XmlElement("UseHoursStep")]
        [DefaultValue(true)]
        public bool UseHoursStep
        {
            get
            {
                return this._useHoursStep;
            }
            set
            {
                this._useHoursStep = value;
            }
        }

        [XmlElement("DaysStep")]
        [DefaultValue(0)]
        public int DaysStep
        {
            get
            {
                return this._daysStep;
            }
            set
            {
                this._daysStep = value;
            }
        }

        [XmlElement("UseDaysStep")]
        [DefaultValue(true)]
        public bool UseDaysStep
        {
            get
            {
                return this._useDaysStep;
            }
            set
            {
                this._useDaysStep = value;
            }
        }

        [XmlElement("WeeksStep")]
        [DefaultValue(0)]
        public int WeeksStep
        {
            get
            {
                return this._weeksStep;
            }
            set
            {
                this._weeksStep = value;
            }
        }

        [XmlElement("UseWeeksStep")]
        [DefaultValue(true)]
        public bool UseWeeksStep
        {
            get
            {
                return this._useWeeksStep;
            }
            set
            {
                this._useWeeksStep = value;
            }
        }

        [XmlElement("MonthesStep")]
        [DefaultValue(0)]
        public int MonthesStep
        {
            get
            {
                return this._monthesStep;
            }
            set
            {
                this._monthesStep = value;
            }
        }

        [XmlElement("UseMonthesStep")]
        [DefaultValue(true)]
        public bool UseMonthesStep
        {
            get
            {
                return this._useMonthesStep;
            }
            set
            {
                this._useMonthesStep = value;
            }
        }

        [XmlElement("UseExponentCalc")]
        [DefaultValue(true)]
        public bool UseExponentCalc
        {
            get
            {
                return this._useExponentCalc;
            }
            set
            {
                this._useExponentCalc = value;
            }
        }

        [XmlElement("UseSameDigitsCalc")]
        [DefaultValue(true)]
        public bool UseSameDigitsCalc
        {
            get
            {
                return this._useSameDigitsCalc;
            }
            set
            {
                this._useSameDigitsCalc = value;
            }
        }

        [XmlElement("MidNumsString")]
        [DefaultValue("2.5;7.5")]
        public string MidNumsString
        {
            get
            {
                return this._midNums;
            }
            set
            {
                this._midNums = value;
            }
        }

        [XmlElement("ContactSort")]
        [DefaultValue("По именам")]
        public string ContactSort
        {
            get
            {
                return this._contactSort;
            }
            set
            {
                this._contactSort = value;
            }
        }

        [XmlIgnore]
        public List<double> MidNums
        {
            get
            {
                List<double> doubleList = new List<double>();
                string str = this._midNums.Replace(',', '.');
                char[] chArray = new char[1] { ';' };
                foreach (string s in str.Split(chArray))
                {
                    double result = 0.0;
                    if (double.TryParse(s, NumberStyles.Any, (IFormatProvider)CultureInfo.InvariantCulture, out result))
                        doubleList.Add(result);
                }
                return doubleList;
            }
        }

        public void Save()
        {
            XmlSerializeHelper.SerializeAndSave(Settings.fileName, (object)this);
        }

        public static Settings Load()
        {
            try
            {
                return Settings.fileName.LoadAndDeserialize<Settings>();
            }
            catch
            {
                return new Settings();
            }
        }
    }
}