Workbook: Meaningful names

1) review1.cs
int elapsedTimeInDays;

2) review2.cs
List<Employee> listOfEmployees = _employeeService.GetEmployees().ToList();

3) review3.cs
int counter;
string fullName;
DateTime modifiedDate;

4) review4.cs
public bool IsShopOpen(string day, int amount)
{
    // some logic
}

5) review5.cs
const int DAYS_IN_WEEK = 7;
const int DAYS_IN_MONTH = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool RestoreDatabase() {}

class Animal {}
class Alpaca {}

6) review6.cs
public class Employee
{
    public Datetime startWorkingDate { get; set; } // get set Start Working Date
    public Datetime modificationTime { get; set; } // get set Modification Time
}

7) review7.cs
var employeePhone;

public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}
