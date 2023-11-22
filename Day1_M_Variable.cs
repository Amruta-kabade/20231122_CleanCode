1) review1.cs

public bool IsShopOpen(string day)
{
    if (string.IsNullOrEmpty(day))
    {
        return false;
    }
    var openingDays = new[] { "friday", "saturday", "sunday" };
    return openingDays.Any(d => d == day.ToLower());

}

2) review3.cs

public long Fibonacci(int n)
{
    if (n > 50)
        throw new System.Exception("Not supported");
    if (n == 0 || n == 1)
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

3) review4.cs

var locations = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < locations.Count(); i++)
{
    var locationIndex = locations[i];
    DoStuff();
    DoSomeOtherStuff();
  
    Dispatch(locations);
}

4) review5.cs

const string ADMIN_ROLE = "Admin";
if(userRole == ADMIN_ROLE)
{
}

5) review6.cs

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    //...
}

6) review7.cs

var yearMonthDate = DateTime.UtcNow.ToString("MMMM dd, yyyy");

7) review8.cs

public void CreateMicrobrewery(string name = null)
{
    var breweryName = "Hipster Brew Co.";
    // ...
}

