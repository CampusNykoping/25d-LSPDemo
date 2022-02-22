using DemoLibrary;

IManager accountingVP = new Manager();

accountingVP.FirstName = "Emma";
accountingVP.LastName = "Stone";
accountingVP.CalculatePerHourRate(4);

//Employee emp = new Employee();
//Employee emp = new Manager(); 
//BaseEmployee emp = new CEO(); 
IManaged emp = new Manager();

emp.FirstName = "Claes";
emp.LastName = "Engelin";
emp.AssignManager(accountingVP);
emp.CalculatePerHourRate(2);

Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

Console.ReadKey();