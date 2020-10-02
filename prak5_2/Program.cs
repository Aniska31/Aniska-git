//Упражнение 2. Сериализация объекта
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialize_People
{
  class Program
  {

    [Serializable()]
    class Person
    {
      public string name;
      public DateTime dateOfBirth;
      public int age;

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
        FileStream fs = new FileStream("Person.Dat", FileMode.Create);
        // Создаем объект BinaryFormatter для выполнения сериализации BinaryFormatter bf = new BinaryFormatter();
        BinaryFormatter bf = new BinaryFormatter();
        // Используем объект BinaryFormatter для сериализации данных в файл bf.Serialize(fs, sp);
        bf.Serialize(fs, sp);
        // Закрываем файл fs.Close();
        fs.Close();
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Пример серилизации №2");
    }
  }
}