using BlazorEmployeeCRUD.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmployeeCRUD.DataAccess
{
    public static class Seed
    {
        public static void GenerateSeed(this ModelBuilder modelBuilder)
        {
            var employees = new[]
            {
                new Employee {EmployeeId=1, FullName="Abc", Department="Sales", DateOfBirth=new DateTime(1999,01,06), Age=25, PhoneNumber="1234567890"},
                new Employee {EmployeeId=2, FullName="Mno", Department="Marketing", DateOfBirth=new DateTime(1999,01,06), Age=24, PhoneNumber="1234567890"},
                new Employee {EmployeeId=3, FullName="Xyz", Department="Excecutive", DateOfBirth=new DateTime(1993,01,06), Age=29, PhoneNumber="1234567890"},
                new Employee {EmployeeId=4, FullName="Dfg", Department="Marketing", DateOfBirth=new DateTime(1999,01,06), Age=25, PhoneNumber="1234567890"},
                new Employee {EmployeeId=5, FullName="Qml", Department="Sales", DateOfBirth=new DateTime(1991,01,06), Age=25, PhoneNumber="1234567890"},
                new Employee {EmployeeId=6, FullName="Bju", Department="Manufacturing", DateOfBirth=new DateTime(1993,01,06), Age=28, PhoneNumber="1234567890"},
                new Employee {EmployeeId=7, FullName="Kgd", Department="Sales", DateOfBirth=new DateTime(1988,01,06), Age=32, PhoneNumber="1234567890"},
                new Employee {EmployeeId=8, FullName="Cey", Department="Marketing", DateOfBirth=new DateTime(1990,01,06), Age=25, PhoneNumber="1234567890"},
                new Employee {EmployeeId=9, FullName="Ndw", Department="Excecutive", DateOfBirth=new DateTime(1998,01,06), Age=26, PhoneNumber="1234567890"},
                new Employee {EmployeeId=10, FullName="Mki", Department="Production", DateOfBirth=new DateTime(2000,01,06), Age=24, PhoneNumber="1234567890"},
            };

            foreach(var employee in employees)
            {
                modelBuilder.Entity<Employee>().HasData(employee);
            }
        }
    }
}
