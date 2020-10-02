// 549 mod 3=0; 0+1=1 variant
using System;
using System.Linq;

namespace prak6
{
  class Program
  {
    public enum Education
    {
      Specialist,
      Вachelor,
      SecondEducation,
    }

    class Person
    {
      private string name;
      private string fam;
      private System.DateTime birth;

      public Person()
      {
        name = "Egor";
        fam = "Anisimov";
        birth = new DateTime(20, 11, 2000);
      }

      public Person(string _name, string _fam, System.DateTime _birth)
      {
        name = _name;
        fam = _fam;
        birth = _birth;
      }

      public string Name
      {
        get { return name; }
        set { name = value; }
      }

      public string Fam
      {
        get { return fam; }
        set { fam = value; }
      }

      public DateTime Birth
      {
        get { return birth; }
        set { birth = value; }
      }

       public override string ToString()
      {
        return fam + name + birth;
      }

      virtual public string ToShortString()
      {
        return fam + name;
      }
    }

    class Exam
    {
      private string subject;
      private int mark;
      private DateTime deadline;

      public Exam(string _subject, int _mark, DateTime _deadline)
      {
        subject = _subject;
        mark = _mark;
        deadline = _deadline;
      }

      public Exam()
      {
        subject = "Programming";
        mark = 5;
        deadline = new DateTime(02, 10, 2020);
      }

      public override string ToString()
      {
        return subject + mark + deadline;
      }

      public string Subject
      {
        get { return subject; }
        set { subject = value; }
      }

      public int Mark
      {
        get { return mark; }
        set { mark = value; }
      }

      public DateTime Deadline
      {
        get { return deadline; }
        set { deadline = value; }
      }
    }

    class Student
    {
      private Person chel; // данные студента
      private Education diplom; // уровень образования
      private int group;
      private Exam[] session; // данные об экзаменах

      public Student() : this(new Person("Egor", "Anisimov", new DateTime(20, 11, 2000)), Education.Вachelor, 5) { }

      public Student(Person _chel, Education _diplom, int _group)
      {
        chel = _chel;
        diplom = _diplom;
        group = _group;
      }

      public Person Chel
      {
        get { return chel; }
        set { chel = value; }
      }

      public Education Diplom
      {
        get { return diplom; }
        set { diplom = value; }
      }

      public int Group
      {
        get { return group; }
        set { group = value; }
      }

      public Exam[] Session
      {
        get { return session; }
        set { session = value; }
      }

      public double Average
      {
        get
        {
          int sum=0;
          for (int i = 0; i < session.Length; i++)
            sum = sum + session.mark[i];
          return (double)sum / (double)session.Length;
        }
      }



    }

     
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
