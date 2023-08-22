using System;
using System.Linq;

namespace dropbox10
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new[]
           {
             new{ Name = "Matthew Fowler", Hours = 80, Pay = 20, Department = "physics"},
             new{ Name = "Edward Rutledge", Hours = 50, Pay = 25, Department = "math"},
             new{ Name = "Nancy Foote", Hours = 100, Pay = 21, Department = "physics"},
             new{ Name = "Carolynn Evan", Hours = 20, Pay = 15, Department = "math"},
             new{ Name = "Laura Hollis", Hours = 60, Pay = 30, Department = "biology"}
         };
            var managers = new[]
            {
             new{ Name = "William Defoe", Salary = 100, OfficeLocation = "Europe", Department = "physics"},
             new{ Name = "Fred Armisted", Salary = 20, OfficeLocation = "North America", Department = "math"},
             new{ Name = "Kara Dorf", Salary = 60, OfficeLocation = "Asia", Department = "biology"}
            };
            var officeQuery = from employee in employees
                              join manager in managers
                              on employee.Department equals manager.Department
                              select new
                              {
                                  employeeName = employee.Name,
                                  supervisorName = manager.Name,
                                  Office = manager.OfficeLocation
                              };
            foreach(var m in officeQuery)
            {
                Console.WriteLine($"Employee's Name: {m.employeeName} Supervisor's Name: {m.supervisorName} Supervisor's Office Location: {m.Office}");
            }
            Console.ReadKey();
        }
    }
}
