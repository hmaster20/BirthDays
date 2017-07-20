using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Days
{
  [Serializable]
  public class DateEvent
  {
    private DateTime _date = DateTime.MinValue;
    private int _id;
    private Contact _contact;
    private int _contactId;
    private uint _quantity;
    private TimeMeasure _timeMeasure;
    private int _timeMeasureId;

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

    [XmlElement("Date")]
    public DateTime Date
    {
      get
      {
        return this._date;
      }
      set
      {
        this._date = value;
      }
    }

    [XmlIgnore]
    public string DateString
    {
      get
      {
        return this._date.ToString("dd.MM.yyyy HH:mm");
      }
    }

    [XmlIgnore]
    public string Info
    {
      get
      {
        return this._quantity.ToString("N0") + " " + this._timeMeasure.ToString(this._quantity);
      }
    }

    [XmlIgnore]
    public Contact Contact
    {
      get
      {
        return this._contact;
      }
      set
      {
        this._contact = value;
      }
    }

    [XmlElement("ContactId")]
    [DefaultValue(-1)]
    public int ContactId
    {
      get
      {
        if (this.Contact == null)
          return this._contactId;
        return this.Contact.Id;
      }
      set
      {
        this._contactId = value;
      }
    }

    [XmlElement("Quantity")]
    [DefaultValue(0)]
    public uint Quantity
    {
      get
      {
        return this._quantity;
      }
      set
      {
        this._quantity = value;
      }
    }

    [XmlIgnore]
    public TimeMeasure TimeMeasure
    {
      get
      {
        return this._timeMeasure;
      }
      set
      {
        this._timeMeasure = value;
      }
    }

    [XmlElement("TimeMeasureId")]
    [DefaultValue(-1)]
    public int TimeMeasureId
    {
      get
      {
        if (this.TimeMeasure == null)
          return this._timeMeasureId;
        return this.TimeMeasure.Id;
      }
      set
      {
        this._timeMeasureId = value;
      }
    }

    public DateEvent()
    {
    }

    public DateEvent(Contact contact, DateTime date, TimeMeasure timeMeasure, uint quantity)
    {
      this._contact = contact;
      this._date = date;
      this._timeMeasure = timeMeasure;
      this._quantity = quantity;
    }

    public static int Comparer(DateEvent a, DateEvent b)
    {
      return DateTime.Compare(a.Date, b.Date);
    }
  }
}
