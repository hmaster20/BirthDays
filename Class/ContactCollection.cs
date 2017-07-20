using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Days
{
  [XmlRoot("ContactCollection")]
  public class ContactCollection
  {
    private static string fileName = "Contacts.xml";
    private List<Contact> _contacts;
    private Dictionary<int, Contact> _contactDictionary;

    [XmlArray("Contacts")]
    [XmlArrayItem("Contact")]
    public List<Contact> Contacts
    {
      get
      {
        return this._contacts;
      }
      set
      {
        this._contacts = value;
      }
    }

    public ContactCollection()
    {
      this._contacts = new List<Contact>();
      this._contactDictionary = new Dictionary<int, Contact>();
    }

    public Contact Add(Contact contact, string sortOrder)
    {
      contact.Id = this.GetNextId();
      this._contacts.Add(contact);
      this._contactDictionary.Add(contact.Id, contact);
      this.Sort(sortOrder);
      return contact;
    }

    public Contact Get(int id)
    {
      if (this._contactDictionary.ContainsKey(id))
        return this._contactDictionary[id];
      return (Contact) null;
    }

    public void Remove(Contact contact)
    {
      if (this._contactDictionary.ContainsKey(contact.Id))
        this._contactDictionary.Remove(contact.Id);
      this._contacts.Remove(contact);
    }

    public void ShiftTime(bool forward, TimeSpan timeShift)
    {
      if (forward)
      {
        foreach (Contact contact in this._contacts)
          contact.BirthDate = contact.BirthDate + timeShift;
      }
      else
      {
        foreach (Contact contact in this._contacts)
          contact.BirthDate = contact.BirthDate - timeShift;
      }
    }

    public void Sort(string order)
    {
      if (order == "По именам")
      {
        this.Contacts.Sort(new Comparison<Contact>(Contact.ComparerByFio));
      }
      else
      {
        if (!(order == "По датам"))
          return;
        this.Contacts.Sort(new Comparison<Contact>(Contact.ComparerByDate));
      }
    }

    private int GetNextId()
    {
      int num1 = 0;
      foreach (int key in this._contactDictionary.Keys)
      {
        if (num1 < key)
          num1 = key;
      }
      int num2;
      return num2 = num1 + 1;
    }

    public void Save()
    {
      XmlSerializeHelper.SerializeAndSave(ContactCollection.fileName, (object) this);
    }

    public static ContactCollection Load()
    {
      ContactCollection contactCollection;
      try
      {
        contactCollection = ContactCollection.fileName.LoadAndDeserialize<ContactCollection>();
      }
      catch
      {
        return new ContactCollection();
      }
      List<Contact> contactList = new List<Contact>();
      foreach (Contact contact in contactCollection._contacts)
      {
        if (contactCollection._contactDictionary.ContainsKey(contact.Id))
          contactList.Add(contact);
        else
          contactCollection._contactDictionary[contact.Id] = contact;
      }
      foreach (Contact contact in contactList)
      {
        contact.Id = contactCollection.GetNextId();
        contactCollection._contactDictionary[contact.Id] = contact;
      }
      return contactCollection;
    }
  }
}
