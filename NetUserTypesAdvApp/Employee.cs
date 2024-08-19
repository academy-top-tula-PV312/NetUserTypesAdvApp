using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUserTypesAdvApp
{
    public class Employee
    {
        static int globalId;

        int id;
        string name;
        int age;
        public string Company { get; set; }

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

class Person
{
    public string Name { set; get; }
    public int Age { set; get; }
}
