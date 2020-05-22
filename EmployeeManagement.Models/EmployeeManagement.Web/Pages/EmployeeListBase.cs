using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
           
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Sanja",
                LastName = "Nastovska",
                Email = "nastovska@gmail.com",
                DateOfBrith = new DateTime(1999, 5, 2),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/sara.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Pedza",
                LastName = "Nikolikj",
                Email = "pedzo@gmail.com",
                DateOfBrith = new DateTime(1999, 1, 17),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/sam.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Ana Marija",
                LastName = "Petrusevska",
                Email = "aneanix@gmail.com",
                DateOfBrith = new DateTime(1998, 8, 28),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/mary.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Tina",
                LastName = "Sotirova",
                Email = "tina@gmail.com",
                DateOfBrith = new DateTime(1999, 3, 18),
                Gender = Gender.Female,
                DepartmentId = 4, 
                PhotoPath = "images/sara.png"
            };

            

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }

    }
}
