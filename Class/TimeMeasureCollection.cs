using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Days
{
  [XmlRoot("TimeMeasureCollection")]
  public class TimeMeasureCollection
  {
    private static string fileName = "TimeMeasures.xml";
    private List<TimeMeasure> _timeMeasures;
    private Dictionary<int, TimeMeasure> _timeMeasureDictionary;

    [XmlArray("TimeMeasures")]
    [XmlArrayItem("TimeMeasure")]
    public List<TimeMeasure> TimeMeasures
    {
      get
      {
        return this._timeMeasures;
      }
      set
      {
        this._timeMeasures = value;
      }
    }

    public TimeMeasureCollection()
    {
      this._timeMeasures = new List<TimeMeasure>();
      this._timeMeasureDictionary = new Dictionary<int, TimeMeasure>();
    }

    public TimeMeasure Add(string name, TimeSpan duration)
    {
      TimeMeasure timeMeasure = new TimeMeasure(name, duration);
      timeMeasure.Id = this.GetNextId();
      this._timeMeasures.Add(timeMeasure);
      this._timeMeasureDictionary.Add(timeMeasure.Id, timeMeasure);
      return timeMeasure;
    }

    public TimeMeasure Get(int id)
    {
      if (this._timeMeasureDictionary.ContainsKey(id))
        return this._timeMeasureDictionary[id];
      return (TimeMeasure) null;
    }

    public TimeMeasure Find(string name)
    {
      return this._timeMeasures.Find((Predicate<TimeMeasure>) (tm => tm.Name == name));
    }

    private int GetNextId()
    {
      int num1 = 0;
      foreach (int key in this._timeMeasureDictionary.Keys)
      {
        if (num1 < key)
          num1 = key;
      }
      int num2;
      return num2 = num1 + 1;
    }

    public void Save()
    {
      XmlSerializeHelper.SerializeAndSave(TimeMeasureCollection.fileName, (object) this);
    }

    public static TimeMeasureCollection Load()
    {
      TimeMeasureCollection measureCollection;
      try
      {
        measureCollection = TimeMeasureCollection.fileName.LoadAndDeserialize<TimeMeasureCollection>();
      }
      catch
      {
        return new TimeMeasureCollection();
      }
      List<TimeMeasure> timeMeasureList = new List<TimeMeasure>();
      foreach (TimeMeasure timeMeasure in measureCollection._timeMeasures)
      {
        if (measureCollection._timeMeasureDictionary.ContainsKey(timeMeasure.Id))
          timeMeasureList.Add(timeMeasure);
        else
          measureCollection._timeMeasureDictionary[timeMeasure.Id] = timeMeasure;
      }
      foreach (TimeMeasure timeMeasure in timeMeasureList)
      {
        timeMeasure.Id = measureCollection.GetNextId();
        measureCollection._timeMeasureDictionary[timeMeasure.Id] = timeMeasure;
      }
      return measureCollection;
    }

    public static TimeMeasureCollection Generate()
    {
      TimeMeasureCollection measureCollection = new TimeMeasureCollection();
      string name1 = "Seconds";
      TimeSpan duration1 = TimeSpan.FromSeconds(1.0);
      TimeMeasure timeMeasure1 = measureCollection.Add(name1, duration1);
      timeMeasure1.Strings.Add(Measure.One, "секунда");
      timeMeasure1.Strings.Add(Measure.Few, "секунды");
      timeMeasure1.Strings.Add(Measure.Many, "секунд");
      string name2 = "Minutes";
      TimeSpan duration2 = TimeSpan.FromMinutes(1.0);
      TimeMeasure timeMeasure2 = measureCollection.Add(name2, duration2);
      timeMeasure2.Strings.Add(Measure.One, "минута");
      timeMeasure2.Strings.Add(Measure.Few, "минуты");
      timeMeasure2.Strings.Add(Measure.Many, "минут");
      string name3 = "Hours";
      TimeSpan duration3 = TimeSpan.FromHours(1.0);
      TimeMeasure timeMeasure3 = measureCollection.Add(name3, duration3);
      timeMeasure3.Strings.Add(Measure.One, "час");
      timeMeasure3.Strings.Add(Measure.Few, "часа");
      timeMeasure3.Strings.Add(Measure.Many, "часов");
      string name4 = "Days";
      TimeSpan duration4 = TimeSpan.FromDays(1.0);
      TimeMeasure timeMeasure4 = measureCollection.Add(name4, duration4);
      timeMeasure4.Strings.Add(Measure.One, "день");
      timeMeasure4.Strings.Add(Measure.Few, "дня");
      timeMeasure4.Strings.Add(Measure.Many, "дней");
      string name5 = "Weeks";
      TimeSpan duration5 = TimeSpan.FromDays(7.0);
      TimeMeasure timeMeasure5 = measureCollection.Add(name5, duration5);
      timeMeasure5.Strings.Add(Measure.One, "неделя");
      timeMeasure5.Strings.Add(Measure.Few, "недели");
      timeMeasure5.Strings.Add(Measure.Many, "недель");
      string name6 = "Monthes";
      TimeSpan zero1 = TimeSpan.Zero;
      TimeMeasure timeMeasure6 = measureCollection.Add(name6, zero1);
      timeMeasure6.Strings.Add(Measure.One, "месяц");
      timeMeasure6.Strings.Add(Measure.Few, "месяца");
      timeMeasure6.Strings.Add(Measure.Many, "месяцев");
      string name7 = "Years";
      TimeSpan zero2 = TimeSpan.Zero;
      TimeMeasure timeMeasure7 = measureCollection.Add(name7, zero2);
      timeMeasure7.Strings.Add(Measure.One, "год");
      timeMeasure7.Strings.Add(Measure.Few, "года");
      timeMeasure7.Strings.Add(Measure.Many, "лет");
      return measureCollection;
    }
  }
}
