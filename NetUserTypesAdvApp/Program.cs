using NetUserTypesAdvApp;

Console.WriteLine("Hello, World!");

Employee employee = new Employee();

employee.SetName("Bobby");
Console.WriteLine(employee.GetName());
employee.Age = 27;
Console.WriteLine(employee.Age);
employee.Company = "Yandex";

Employee.globalId = 10;

double x = 15.5;
Console.WriteLine(Math.Sin(x));


