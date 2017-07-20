using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Days
{
    public class Contact
    {
        private DateTime _birthDate = DateTime.MinValue;
        private int _id;
        private string _fio;
        private string _info;

        [XmlElement("Id")]
        [DefaultValue(0)]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [XmlElement("Fio")]
        [DefaultValue("")]
        public string Fio
        {
            get
            {
                return this._fio;
            }
            set
            {
                this._fio = value;
            }
        }

        [XmlElement("BirthDate")]
        public DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }

        [XmlIgnore]
        public string BirthDateString
        {
            get
            {
                return this._birthDate.ToString("dd.MM.yyyy HH:mm");
            }
        }

        [XmlElement("Info")]
        [DefaultValue("")]
        public string Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }

        public Contact()
        {
        }

        public Contact(string fio, DateTime birthDate, string info)
        {
            this._fio = fio;
            this._birthDate = birthDate;
            this._info = info;
        }

        public override string ToString()
        {
            return this._fio;
        }

        public static int ComparerByFio(Contact a, Contact b)
        {
            return string.Compare(a.Fio, b.Fio);
        }

        public static int ComparerByDate(Contact a, Contact b)
        {
            int year1 = 2000;
            DateTime birthDate1 = a.BirthDate;
            int month1 = birthDate1.Month;
            birthDate1 = a.BirthDate;
            int day1 = birthDate1.Day;
            birthDate1 = a.BirthDate;
            int hour1 = birthDate1.Hour;
            birthDate1 = a.BirthDate;
            int minute1 = birthDate1.Minute;
            birthDate1 = a.BirthDate;
            int second1 = birthDate1.Second;
            DateTime t1 = new DateTime(year1, month1, day1, hour1, minute1, second1);

            int year2 = 2000;
            DateTime birthDate2 = b.BirthDate;
            int month2 = birthDate2.Month;
            birthDate2 = b.BirthDate;
            int day2 = birthDate2.Day;
            birthDate2 = b.BirthDate;
            int hour2 = birthDate2.Hour;
            birthDate2 = b.BirthDate;
            int minute2 = birthDate2.Minute;
            birthDate2 = b.BirthDate;
            int second2 = birthDate2.Second;
            // ISSUE: explicit reference operation
            DateTime t2 = new DateTime(year2, month2, day2, hour2, minute2, second2);
            return DateTime.Compare(t1, t2);
        }
    }
}