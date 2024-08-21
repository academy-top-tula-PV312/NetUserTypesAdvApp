using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUserTypesAdvApp
{
    public class Employee
    {
        public static int globalId;
        public const int MAX = 100;

        int id;
        string name;
        int age;
        public string? Company { get; set; }

        public CCity City { get; set; }

        public string GetName() { return name; }

        static Employee()
        {
            globalId = 1;
        }

        public Employee()
        {
            id = globalId++;
        }

        public void SetName(string value)
        {
            if(value != "")
                name = value;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 0) 
                    age = value;
            }
        }

        //public string Company
        //{
        //    get
        //    {
        //        return company;
        //    }
        //    set
        //    {
        //        company = value;
        //    }
        //}
    }
}

struct Person
{
    public string Name { set; get; }
    public int Age { set; get; }
}

class Region
{
    public string Name { set; get; }
    readonly int code;

    public Region()
    {
        this.Name = "";
        this.code = 0;
    }

    public Region(string name, int code)
    {
        this.Name = name;
        this.code = code;
    }

    public int Code
    {
        get
        {
            return code;
        }
    }
}

readonly struct Money
{
    readonly public double Usd;
    readonly public double Euro;

    public Money(double usd, double euro)
    {
        this.Usd = usd;
        this.Euro = euro;
    }
}

public class CCity
{
    public string Title { set; get; }
}

struct SCity
{
    public string Title { set; get; }
}

record RCity
{
    public string Title { set; get; }
}

readonly record struct Book(string Author, string Title, int Year);

//record Book1
//{
//    public string Author { set; get; }
//    public string Title { set; get; }
//    public int Year { set; get; }

//    public Book1(string author, string title, int year)
//    {
//        this.Author = author;
//        this.Title = title;
//        this.Year = year;
//    }

//    public void Deconstruct(out string author, out string title, out int year)
//    {
//        author = this.Author;
//        title = this.Title;
//        year = this.Year;
//    }
//}