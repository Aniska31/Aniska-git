// 549 mod 3=0; 0+1=1 variant
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      private List<Exam> session; // данные об экзаменах

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

      public List <Exam> Session
      {
        get { return session; }
                set
                {
                    int i = 0;
                    foreach (Exam _exam in value)
                    {
                        session[i++] = _exam;
                    }
                }
       }

      public double Average
      {
        get
        {
          int sum=0;
          int flag = 0;
          foreach(Exam _session in session)
          {
            sum = sum + _session.Mark;
            flag++;
          }
          return (double)sum / (double)flag;
        }
      }

     public bool this [Education _diplom]
      {
        get
        {
            bool check;
            if (_diplom == diplom)
                check = true;
            else
                check = false;
            return check;


        }
      }

    public void AddExams (params Exam[] _session)
    {
            foreach (Exam _elem in _session)
                session.Add(_elem);
    }

    public override string ToString()
    {
        string str = "";
        int i = 0;
        foreach (Exam _exam in Session)
        {
            i++;
            str = str + i + ". " + _exam.ToString() + "\n";
        }
        return chel.ToString() + "\n" + Diplom + "\n" + Group + "\n" + str;
    }

    public virtual string ToShortString()
    {
        return chel.ToString() + "\n" + Diplom + "\n" + Group + "\n" + "middle mark: " + Average;
    }
    }

     
    static void Main(string[] args)
    {
        Student I = new Student();
        I.ToShortString();
    }
  }
}
