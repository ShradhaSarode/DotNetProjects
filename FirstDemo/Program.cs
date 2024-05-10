// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, Shradha!");

char c1 = 's';// 1 byte
string name = "Shradha";//7 byte
int a = 10;// 4 byte
short s1 = 12;//2 byte
long l1 = 99701401;// 8 byte
float f1 = 32.5f;//4 byte
double d1 = 45.5;//8 byte
decimal d2 = 22.12M;//16 byte

// print the output
Console.WriteLine("int num is : "+a+" decimal num is: "+d2);
//using placeholder  OR                                    0  1   
Console.WriteLine("int num is {0} and float value is {1} ",a,f1);
//string interpolation---> $ OR
Console.WriteLine($"int num is {a} and float value is {f1}");

Console.WriteLine("---------------------------");

Console.WriteLine("Enter your name: ");
string st1 = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your salary: ");
double sal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Hello, {st1} ,your age is {age} , and salary is {sal}");



using FirstDemo;

Employee emp = new Employee();
emp.Assign();
emp.CalculateSalary();
string result = emp.Display();
Console.WriteLine(result);

Employee emp2 = new Employee();
emp2.Accept(101, "Shradha", 4500.5, 3200, 500);
emp2.CalculateSalary();
Console.WriteLine(emp2.Display());

Console.WriteLine("--------------------------------------");

Student s1 = new Student();
Student s2 = new Student(2,"Shreya");
Student s3 = new Student(3,"Siddhant",4500);

Console.WriteLine(s1.Display());
Console.WriteLine(s2.Display());
Console.WriteLine(s3.Display());

Console.WriteLine("-----------------------------------------------------");

Date d1 = new Date();
Date d2 = new Date(05, 08, 1990);

Console.WriteLine(d1.Display());
Console.WriteLine(d2.Display());

Console.WriteLine("---------------------------------------------------------");

Product p1 = new Product();
p1.Code = 101;
p1.Name = "Keyboard";
p1.Price = 1000;

Console.WriteLine($"Product Code: {p1.Code},Name: {p1.Name},Price: {p1.Price}");

Product p2 = new Product { Code = 102,Name = "Motherboard",Price = 40000 };
Console.WriteLine($"Product Code: {p2.Code},Name: {p2.Name},Price: {p2.Price}");
Console.WriteLine("---------------------------------------------------------");

Book b1 = new Book {Bid=1,Bname="C#",Price=600 };
Console.WriteLine($"Book id: {b1.Bid},Name: {b1.Bname},Price: {b1.Price}");
Console.WriteLine("---------------------------------------------------------");



using FirstDemo;

Job j1 = new Job();
Console.WriteLine("Job Tax: "+j1.PayTax());

Business b1 = new Business();
Console.WriteLine("Business Tax: "+b1.PayTax());

Console.WriteLine("-----------------------------------");
ICustomer c1 = new Trasaction();

Console.WriteLine("ICustomer : "+ c1.Print()); // customer 

IOrder o1 = new Trasaction();
Console.WriteLine("IOrder: " + o1.Print()); // order
Console.WriteLine("-----------------------------------");

Calculator ca1 = new Calculator();
Console.WriteLine("Sub: "+ca1.Sub(30, 20));
Console.WriteLine("Add: "+ca1.Add(20, 60));
Console.WriteLine("-----------------------------------");

Product1[] pro1 = new Product1[5];
pro1[0] = new Product1(101, "Mobile", 35000);
pro1[1] = new Product1(102, "Laptop", 70000); 
pro1[2] = new Product1(103, "Speaker", 599);
pro1[3] = new Product1(104, "TV", 200000);
pro1[4] = new Product1(105, "Remote", 699);
pro1[5] = new Product1(106, "RAM", 6099);


for (int i = 0; i < pro1.Length; i++)
{
    Console.WriteLine("Product " + (i + 1) + " details:");
    pro1[i].DisplayDetails();
    Console.WriteLine("---------------------");
}
Console.WriteLine("-------------------------------");
Console.WriteLine("Using For each loop");
Console.WriteLine("-------------------------------");
foreach (Product1 p in pro1)
{
    p.DisplayDetails();
    Console.WriteLine("---------------------");
}
*/