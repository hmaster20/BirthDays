using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Days
{
  [XmlRoot("DateEventCollection")]
  public class DateEventCollection
  {
    private static string fileName = "DateEvents.xml";
    private List<DateEvent> _dateEvents;
    private Dictionary<int, DateEvent> _dateEventDictionary;

    [XmlArray("DateEvents")]
    [XmlArrayItem("DateEvent")]
    public List<DateEvent> DateEvents
    {
      get
      {
        return this._dateEvents;
      }
      set
      {
        this._dateEvents = value;
      }
    }

    public DateEventCollection()
    {
      this._dateEvents = new List<DateEvent>();
      this._dateEventDictionary = new Dictionary<int, DateEvent>();
    }

    public void Add(Contact contact, TimeMeasureCollection timeMeasures, Settings settings)
    {
      if (settings.UseSeconds)
      {
        TimeMeasure timeMeasure = timeMeasures.Find("Seconds");
        if (timeMeasure != null)
          this.CalculateEvents(contact, timeMeasure, settings);
      }
      if (settings.UseMinutes)
      {
        TimeMeasure timeMeasure = timeMeasures.Find("Minutes");
        if (timeMeasure != null)
          this.CalculateEvents(contact, timeMeasure, settings);
      }
      if (settings.UseHours)
      {
        TimeMeasure timeMeasure = timeMeasures.Find("Hours");
        if (timeMeasure != null)
          this.CalculateEvents(contact, timeMeasure, settings);
      }
      if (settings.UseDays)
      {
        TimeMeasure timeMeasure = timeMeasures.Find("Days");
        if (timeMeasure != null)
          this.CalculateEvents(contact, timeMeasure, settings);
      }
      if (settings.UseWeeks)
      {
        TimeMeasure timeMeasure = timeMeasures.Find("Weeks");
        if (timeMeasure != null)
          this.CalculateEvents(contact, timeMeasure, settings);
      }
      if (settings.UseMonthes)
      {
        TimeMeasure timeMeasure = timeMeasures.Find("Monthes");
        if (timeMeasure != null)
          this.CalculateLongEvents(contact, timeMeasure, settings);
      }
      if (!settings.UseYears)
        return;
      TimeMeasure timeMeasure1 = timeMeasures.Find("Years");
      if (timeMeasure1 == null)
        return;
      this.CalculateLongEvents(contact, timeMeasure1, settings);
    }

    public void Remove(Contact contact)
    {
      List<DateEvent> all = this._dateEvents.FindAll((Predicate<DateEvent>) (de => de.ContactId == contact.Id));
      this._dateEvents.RemoveAll((Predicate<DateEvent>) (de => de.ContactId == contact.Id));
      foreach (DateEvent dateEvent in all)
        this._dateEventDictionary.Remove(dateEvent.Id);
    }

    public void Recalc(ContactCollection contacts, TimeMeasureCollection timeMeasures, Settings settings)
    {
      this._dateEvents.Clear();
      this._dateEventDictionary.Clear();
      foreach (Contact contact in contacts.Contacts)
        this.Add(contact, timeMeasures, settings);
    }

    public List<DateEvent> GetTodayEvents()
    {
      return this._dateEvents.FindAll((Predicate<DateEvent>) (de =>
      {
        DateTime dateTime = de.Date;
        DateTime date1 = dateTime.Date;
        dateTime = DateTime.Now;
        DateTime date2 = dateTime.Date;
        return date1 == date2;
      }));
    }

    public List<DateEvent> GetFutureEvents()
    {
      return this._dateEvents.FindAll((Predicate<DateEvent>) (de => de.Date.Date >= DateTime.Today));
    }

    public List<DateEvent> GetPastEvents()
    {
      return this._dateEvents.FindAll((Predicate<DateEvent>) (de => de.Date.Date < DateTime.Today));
    }

    public void Save()
    {
      XmlSerializeHelper.SerializeAndSave(DateEventCollection.fileName, (object) this);
    }

    public static DateEventCollection Load(TimeMeasureCollection timeMeasures, ContactCollection contacts)
    {
      DateEventCollection dateEventCollection;
      try
      {
        dateEventCollection = DateEventCollection.fileName.LoadAndDeserialize<DateEventCollection>();
      }
      catch
      {
        return new DateEventCollection();
      }
      List<DateEvent> dateEventList = new List<DateEvent>();
      foreach (DateEvent dateEvent in dateEventCollection.DateEvents)
      {
        dateEvent.TimeMeasure = timeMeasures.Get(dateEvent.TimeMeasureId);
        dateEvent.Contact = contacts.Get(dateEvent.ContactId);
        if (dateEventCollection._dateEventDictionary.ContainsKey(dateEvent.Id))
          dateEventList.Add(dateEvent);
        else
          dateEventCollection._dateEventDictionary[dateEvent.Id] = dateEvent;
      }
      foreach (DateEvent dateEvent in dateEventList)
      {
        dateEvent.Id = dateEventCollection.GetNextId();
        dateEventCollection._dateEventDictionary[dateEvent.Id] = dateEvent;
      }
      return dateEventCollection;
    }

    private int GetNextId()
    {
      int num1 = 0;
      foreach (int key in this._dateEventDictionary.Keys)
      {
        if (num1 < key)
          num1 = key;
      }
      int num2;
      return num2 = num1 + 1;
    }

    private DateEvent Add(Contact contact, DateTime date, TimeMeasure timeMeasure, uint quantity)
    {
      if (this._dateEvents.Exists((Predicate<DateEvent>) (de =>
      {
        if (de.Contact.Id == contact.Id && (int) de.Quantity == (int) quantity)
          return de.TimeMeasure.Id == timeMeasure.Id;
        return false;
      })))
        return (DateEvent) null;
      DateEvent dateEvent = new DateEvent(contact, date, timeMeasure, quantity);
      dateEvent.Id = this.GetNextId();
      this._dateEvents.Add(dateEvent);
      this._dateEventDictionary.Add(dateEvent.Id, dateEvent);
      this._dateEvents.Sort(new Comparison<DateEvent>(DateEvent.Comparer));
      return dateEvent;
    }

    private void CalculateEvents(Contact contact, TimeMeasure timeMeasure, Settings settings)
    {
      DateTime birthDate1 = contact.BirthDate;
      DateTime dateTime1 = DateTime.Now + TimeSpan.FromDays((double) settings.NextDaysQuantity);
      DateTime dateTime2 = DateTime.Now - TimeSpan.FromDays((double) settings.PreviousDaysQuantity);
      if (settings.UseExponentCalc)
      {
        uint num = 1;
        DateTime date = birthDate1 + TimeSpan.FromTicks(timeMeasure.Duration.Ticks * (long) num);
        while (date < dateTime1)
        {
          for (uint index = 1; index < 10U; ++index)
          {
            if (date > dateTime2 && date < dateTime1)
              this.Add(contact, date, timeMeasure, index * num);
            date += TimeSpan.FromTicks(timeMeasure.Duration.Ticks * (long) num);
            if (date > dateTime1)
              break;
          }
          num *= 10U;
        }
      }
      if (settings.UseSameDigitsCalc)
      {
        int num1 = 1;
        DateTime birthDate2 = contact.BirthDate;
        while (birthDate2 < dateTime1)
        {
          uint num2 = 0;
          for (int index = 0; index < num1; ++index)
            num2 += (uint) Math.Pow(10.0, (double) index);
          ++num1;
          birthDate2 = contact.BirthDate;
          for (uint index = 1; index < 10U; ++index)
          {
            birthDate2 += TimeSpan.FromTicks(timeMeasure.Duration.Ticks * (long) num2);
            if (birthDate2 > dateTime2 && birthDate2 < dateTime1)
              this.Add(contact, birthDate2, timeMeasure, index * num2);
            if (birthDate2 > dateTime1)
              break;
          }
        }
      }
      foreach (double midNum in settings.MidNums)
      {
        uint num = 1;
        while (contact.BirthDate.AddTicks(timeMeasure.Duration.Ticks * (long) num) < dateTime1)
        {
          uint quantity = (uint) ((double) num * midNum);
          if ((double) quantity == (double) num * midNum)
          {
            DateTime date = contact.BirthDate.AddTicks(timeMeasure.Duration.Ticks * (long) quantity);
            if (date > dateTime2 && date < dateTime1)
              this.Add(contact, date, timeMeasure, quantity);
          }
          num *= 10U;
        }
      }
    }

    private void CalculateLongEvents(Contact contact, TimeMeasure timeMeasure, Settings settings)
    {
      if (timeMeasure.Name != "Monthes" && timeMeasure.Name != "Years")
        return;
      DateTime date1 = contact.BirthDate;
      DateTime dateTime1 = DateTime.Now + TimeSpan.FromDays((double) settings.NextDaysQuantity);
      DateTime dateTime2 = DateTime.Now - TimeSpan.FromDays((double) settings.PreviousDaysQuantity);
      if (settings.UseExponentCalc)
      {
        int months = 1;
        while (date1 < dateTime1)
        {
          if (timeMeasure.Name == "Years" && settings.CalcEveryYear)
          {
            date1 = date1.AddYears(1);
            if (date1 > dateTime2 && date1 < dateTime1)
              this.Add(contact, date1, timeMeasure, (uint) months);
            ++months;
          }
          else
          {
            for (int index = 1; index <= 10; ++index)
            {
              if (timeMeasure.Name == "Monthes")
                date1 = date1.AddMonths(months);
              else if (timeMeasure.Name == "Years")
                date1 = date1.AddYears(months);
              if (date1 > dateTime2 && date1 < dateTime1)
                this.Add(contact, date1, timeMeasure, (uint) (index * months));
              if (date1 > dateTime1)
                break;
            }
            months *= 10;
          }
        }
      }
      if (settings.UseSameDigitsCalc)
      {
        int num = 1;
        date1 = contact.BirthDate;
        while (date1 < dateTime1)
        {
          int months = 0;
          for (int index = 0; index < num; ++index)
            months += (int) Math.Pow(10.0, (double) index);
          ++num;
          date1 = contact.BirthDate;
          for (uint index = 1; index < 10U; ++index)
          {
            if (timeMeasure.Name == "Monthes")
              date1 = date1.AddMonths(months);
            else if (timeMeasure.Name == "Years")
              date1 = date1.AddYears(months);
            if (date1 > dateTime2 && date1 < dateTime1)
              this.Add(contact, date1, timeMeasure, (uint) ((ulong) index * (ulong) months));
            if (date1 > dateTime1)
              break;
          }
        }
      }
      foreach (double midNum in settings.MidNums)
      {
        int months1 = 1;
        while (timeMeasure.Name == "Monthes" && contact.BirthDate.AddMonths(months1) < dateTime1 || timeMeasure.Name == "Years" && contact.BirthDate.AddYears(months1) < dateTime1)
        {
          int months2 = (int) ((double) months1 * midNum);
          if ((double) months2 == (double) months1 * midNum)
          {
            DateTime date2 = DateTime.MinValue;
            if (timeMeasure.Name == "Monthes")
              date2 = contact.BirthDate.AddMonths(months2);
            else if (timeMeasure.Name == "Years")
              date2 = contact.BirthDate.AddYears(months2);
            if (date2 > dateTime2 && date2 < dateTime1)
              this.Add(contact, date2, timeMeasure, (uint) months2);
          }
          months1 *= 10;
        }
      }
    }
  }
}
