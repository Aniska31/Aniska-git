//Упражнение. Замена двоичной сериализации на сериализацию XML
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialize_People
{
  class Program
  {

    [Serializable()]
    class Person : IDeserializationCallback
    {
      public string name;
      public DateTime dateOfBirth;
      [NonSerialized] public int age;

      public Person(string _name, DateTime _dateOfBirth)
      {
        name = _name;
        dateOfBirth = _dateOfBirth;
        CalculateAge();
      }

      public Person()
      {
      }

      public override string ToString()
      {
        return name + " was born on " + dateOfBirth.ToShortDateString() + " and is " + age.ToString() + " years old.";
      }

      private void CalculateAge()
      {
        age = DateTime.Now.Year - dateOfBirth.Year;

        // If they haven't had their birthday this year, 
        // subtract a year from their age
        if (dateOfBirth.AddYears(DateTime.Now.Year - dateOfBirth.Year) > DateTime.Now)
        {
          age--;
        }
      }

      private static void Serialize(Person sp)
      {
        // Создаем файл для сохранения данных
        FileStream fs = new FileStream("Person.XML", FileMode.Create);

        // Создаем объект XmlSerializer для выполнения сериализации 
        XmlSerializer xs = new XmlSerializer(typeof(Person));

        // Используем объект XmlSerializer для сериализации данных в файл
        xs.Serialize(fs, sp);

        // Закрываем файл
        fs.Close();
      }


      private static Person Deserialize()
      {
        Person dsp = new Person();

        // Создаем файл для сохранения данных
        FileStream fs = new FileStream("Person.XML", FileMode.Open);

        // Создаем объект XmlSerializer для выполнения десериализации
        XmlSerializer xs = new XmlSerializer(typeof(Person));
        // Используем объект XmlSerializer для десериализации данных в файл
        dsp = (Person)xs.Deserialize(fs);

        // Закрываем файл fs.Close(); return dsp;
        fs.Close();
        return dsp;
      }


      void IDeserializationCallback.OnDeserialization(Object sender)
      {
        // После десериализации вычисляем возраст 
        CalculateAge();
      }

    }

    static void Main(string[] args)
    {
      Console.WriteLine("Пример серилизации №5");
    }
  }
}