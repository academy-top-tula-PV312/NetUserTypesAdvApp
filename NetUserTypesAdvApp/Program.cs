using cout = System.Console;
using NetUserTypesAdvApp;


cout.WriteLine("Hello world");

//Console.WriteLine("Hello, World!");

//Employee employee = new Employee();

//employee.SetName("Bobby");
//Console.WriteLine(employee.GetName());
//employee.Age = 27;
//Console.WriteLine(employee.Age);
//employee.Company = "Yandex";

//Employee.globalId = 10;
//int a = Employee.MAX;

//double x = 15.5;
//Console.WriteLine(Math.Sin(x));

//const int MAX = 100;


// -------------------------------------------

//CCity tula1 = new() { Title = "Tula" };
//CCity tula2 = new() { Title = "Tula" };
//CCity tula3 = tula1;
//tula3.Title = "Тула";

//Console.WriteLine(tula1.Equals(tula2));
//Console.WriteLine(tula1.Equals(tula3));
//Console.WriteLine($"{tula1.Title}\n");


//SCity orel1 = new() { Title = "Orel" };
//SCity orel2 = new() { Title = "Orel" };
//SCity orel3 = orel1;
//orel3.Title = "Орел";

//Console.WriteLine(orel1.Equals(orel2));
//Console.WriteLine(orel1.Equals(orel3));
//Console.WriteLine($"{orel1.Title}\n");


//RCity kaluga1 = new() { Title = "Kaluga" };
//RCity kaluga2 = new() { Title = "Kaluga" };
//RCity kaluga3 = kaluga1;
//kaluga3.Title = "Калуга";

//Console.WriteLine(kaluga1.Equals(kaluga2));
//Console.WriteLine(kaluga1.Equals(kaluga3));
//Console.WriteLine($"{kaluga1.Title}\n");


//(string title, int code) tuple = (title: "Tula", code: 71);

//Console.WriteLine(tuple.title);
//Console.WriteLine(tuple.code);

//int a = 20;
//int b = 30;

////int t = a;
////a = b;
////b = t;

//(a, b) = (b, a);

//(int, int) MinMax(int[] array)
//{
//    int min, max;
//    min = max = array[0];

//    foreach(int item in array)
//    {
//        if (min > item) min = item;
//        if (max < item) max = item;
//    }

//    return (min, max);
//}

//void Function((int code, string name) tuple)
//{

//}

Employee employee = new() { Age = 28 };
employee.SetName("Bobby");
employee.City = new() { Title = "Moscow" };

Console.WriteLine(employee?.City?.Title);

if (employee is not null)
    if (employee.City is not null)
        if (employee.City.Title is not null)
            Console.WriteLine(employee.City.Title);


object? obj = 10;

int? a = (int?)obj;
Console.WriteLine($"Has: {a.HasValue}, value: {a.GetValueOrDefault()}");

a = null;
Console.WriteLine($"Has: {a.HasValue}, value: {a.GetValueOrDefault()}");

int b;
b = 20 / (a ?? 1);







