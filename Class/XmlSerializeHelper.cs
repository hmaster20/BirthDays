using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Days
{
  public static class XmlSerializeHelper
  {
    public static bool SerializeAndSave(string filename, object objectToSerialize)
    {
      XmlSerializer xmlSerializer = new XmlSerializer(objectToSerialize.GetType());
      try
      {
        using (FileStream fileStream = new FileStream(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), filename), FileMode.Create))
          xmlSerializer.Serialize((Stream) fileStream, objectToSerialize);
      }
      catch
      {
        return false;
      }
      return true;
    }

    public static T LoadAndDeserialize<T>(this string filename)
    {
      if (!File.Exists(filename))
        throw new Exception("File not exist");
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (T));
      try
      {
        using (FileStream fileStream = new FileStream(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), filename), FileMode.Open))
          return (T) xmlSerializer.Deserialize((Stream) fileStream);
      }
      catch
      {
        throw new Exception("Error during deserializing");
      }
    }
  }
}
