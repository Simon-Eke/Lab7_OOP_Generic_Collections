using Lab7_OOP_Generic_Collections;

Employee employee1 = new Employee("A001", "John", "Male", 32000);
Employee employee2 = new Employee("A002", "Karl", "Non-binary", 47000);
Employee employee3 = new Employee("A003", "Liz", "Female", 51000);
Employee employee4 = new Employee("A004", "Maggie", "Female", 28500);
Employee employee5 = new Employee("A005", "Niall", "Male", 37400);

Stack<Employee> Employees = new Stack<Employee>();
Employees.Push(employee1);
Employees.Push(employee2);
Employees.Push(employee3);
Employees.Push(employee4);
Employees.Push(employee5);

// Prints all objects in the stack
foreach (Employee employee in Employees)
{
    Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
    Console.WriteLine($"Items left in the stack: {Employees.Count}");
}

Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("Retrieve using Pop-method");

Stack<Employee> Employees2 = new Stack<Employee>();
while (Employees.Count > 0)
{
    var poppedEmployee = Employees.Pop();
    Console.WriteLine($"{poppedEmployee.Id} - {poppedEmployee.Name} - {poppedEmployee.Gender} - {poppedEmployee.Salary}");
    Console.WriteLine($"Items left in the stack: {Employees.Count}");
    Employees2.Push(poppedEmployee);
}

Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("Retrieve using Peek-method");

// Employees2 is now in reversed order 

while (Employees2.Count > 0)
{
    var poppedEmployee = Employees2.Pop();    
    Employees.Push(poppedEmployee);
}

// Employees is now in the original order

for (int i = 0; i < 2; i++)
{
    var peekedEmployee = Employees.Peek();
    Console.WriteLine($"{peekedEmployee.Id} - {peekedEmployee.Name} - {peekedEmployee.Gender} - {peekedEmployee.Salary}");
    Console.WriteLine($"Items left in the stack: {Employees.Count}");
}

Console.WriteLine("-----------------------------------------------------------------");

// Does the stack contain employee nr 3?
bool emp3isInStack = Employees.Contains(employee3);
string result = emp3isInStack ? "Emp3 is in the Stack" : "Emp3 is not in the Stack";
Console.WriteLine(result);

Console.WriteLine("\n-----------------------------------------------------------------");

List<Employee> ListOfEmployees = new();
ListOfEmployees.Add(employee1);
ListOfEmployees.Add(employee2);
ListOfEmployees.Add(employee3);
ListOfEmployees.Add(employee4);
ListOfEmployees.Add(employee5);

bool emp2isInList = ListOfEmployees.Contains(employee2);
result = emp2isInList ? "Employee2 object exists in the list" : "Employee2 object does not exist in the list";
Console.WriteLine(result);


// Maybe TODO - Create a Ternary Operator instead of an if-statement
var male = ListOfEmployees.Find(v => v.Gender == "Male");
if (male != null)
{
    Console.WriteLine($"\nId = {male.Id}, Name = {male.Name}, Gender = {male.Gender}, Salary = {male.Salary}\n");
}
else
{
    Console.WriteLine("\nNo males exists in the List of employees");
}

var males = ListOfEmployees.FindAll(v => v.Gender == "Male");
foreach (var genderMale in males)
{
    Console.WriteLine($"Id = {genderMale.Id}, Name = {genderMale.Name}, Gender = {genderMale.Gender}, Salary = {genderMale.Salary}");
}