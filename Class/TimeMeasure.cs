using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Days
{
  public class TimeMeasure
  {
    private int _id;
    private string _name;
    private Dictionary<Measure, string> _strings;
    private TimeSpan _duration;

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

    [XmlElement("Name")]
    [DefaultValue("")]
    public string Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    [XmlIgnore]
    public Dictionary<Measure, string> Strings
    {
      get
      {
        return this._strings;
      }
      set
      {
        this._strings = value;
      }
    }

    [XmlArray("Strings")]
    [XmlArrayItem("String")]
    public List<DictionaryItem> StringsList
    {
      get
      {
        List<DictionaryItem> dictionaryItemList1 = new List<DictionaryItem>();
        foreach (Measure key in this._strings.Keys)
        {
          List<DictionaryItem> dictionaryItemList2 = dictionaryItemList1;
          DictionaryItem dictionaryItem = new DictionaryItem();
          dictionaryItem.Id = (int) key;
          string str = this._strings[key];
          dictionaryItem.String = str;
          dictionaryItemList2.Add(dictionaryItem);
        }
        return dictionaryItemList1;
      }
      set
      {
        this._strings = new Dictionary<Measure, string>();
        foreach (DictionaryItem dictionaryItem in value)
          this._strings.Add((Measure) dictionaryItem.Id, dictionaryItem.String);
      }
    }

    [XmlElement("Duration")]
    public TimeSpan Duration
    {
      get
      {
        return this._duration;
      }
      set
      {
        this._duration = value;
      }
    }

    public TimeMeasure()
    {
      this._strings = new Dictionary<Measure, string>();
    }

    public TimeMeasure(string name, TimeSpan duration)
      : this()
    {
      this._name = name;
      this._duration = duration;
    }

    public override string ToString()
    {
      return this._name;
    }

    public string ToString(uint quantity)
    {
      int num = (int) (quantity % 100U);
      Measure key = num > 4 && num <= 20 || (num % 10 == 0 || num % 10 > 4) ? Measure.Many : (num % 10 != 1 ? Measure.Few : Measure.One);
      if (this._strings.ContainsKey(key))
        return this._strings[key];
      return this._name;
    }
  }
}
