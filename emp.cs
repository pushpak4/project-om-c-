using System;
namespace employee
{
public class ed
{
public void employeedetails()
{
int emp_id;
int emp_age;
Console.WriteLine("Enter name ");
Console.ReadLine();
Console.WriteLine("Enter id ");
emp_id=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter address ");
Console.ReadLine();
Console.WriteLine("Enter age ");
emp_age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter gender ");
Console.ReadLine();
Console.WriteLine("Enter designation ");
Console.ReadLine();
}
}
public class eda
{  
public void attend()
{
int days;
int att;
Console.WriteLine("PRESENT PRECENTAGE");
Console.WriteLine("Enter number of days present ");
days=Convert.ToInt32(Console.ReadLine());
att = days * 100 / 30;
Console.Write("Number of days present precentage is "+att);
Console.ReadLine();
}
}
public class eds
{
public void salary()
{
int days;
int sal;
int ded;
int deu;
int dedu;
Console.WriteLine("SALARY AFTER PF DEDUCTION");
Console.WriteLine("Enter number of days present ");
days=Convert.ToInt32(Console.ReadLine());
sal = days * 5000;
Console.Write("Salary per month is "+sal);
Console.ReadLine();
ded = sal / 100  ;
deu = ded * 12 ;
Console.Write("Salary after PF percentage is "+deu);
Console.ReadLine();
dedu = sal - ded ;
Console.Write("Salary after PF deduction is "+dedu);
Console.ReadLine();
}
}
class employee
{
public static void Main()
{
ed e1= new ed();
e1.employeedetails();
eda e2= new eda();
e2.attend();
eds e3= new eds();
e3.salary();
}
}
}