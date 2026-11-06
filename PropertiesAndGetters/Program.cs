using PropertiesAndGetters.Models;

Student student = new Student();
student.Name = "Anna";
student.Age = 17;


student.ShowInfo();
student.Age++; // -> get -> ++ -> set

student.Age = -100;

student.ShowInfo();


Rectangle rect = new Rectangle() {Width = 2.5, Height=2.5 };
Console.WriteLine($"Pole: {rect.Area}, Obwód: {rect.Perimiter}, Czy jest kwadratem: {rect.IsSquare}");

Point2D p1 = new Point2D();
Point2D p2 = new Point2D();

p1.MoteBy(2.75, -1.20);
p2.MoteBy(-3.5, 2.25);

Console.WriteLine($"Odleglosc p1 od p2: {p1.Distance(p2)} oraz {p2.Distance(p1)}");
